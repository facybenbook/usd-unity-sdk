﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using USD.NET;

/// <summary>
/// Loads mesh and transform data from a USD file into the Unity GameObject hierarchy and creates
/// meshes.
/// </summary>
public class LoadMeshExample : MonoBehaviour {

  public string m_usdFile;
  public Material m_material;

  // The range is arbitrary, but adding it provides a slider in the UI.
  [Range(0, 100)] public float m_usdTime;

  private Scene m_scene;

  // Keep track of all objects loaded.
  private Dictionary<string, GameObject> m_primMap = new Dictionary<string, GameObject>();

  void Start () {
    InitUsd.Initialize();
  }

  void Update () {
    if (string.IsNullOrEmpty(m_usdFile)) {
      if (m_scene == null) {
        return;
      }
      m_scene.Close();
      m_scene = null;
      UnloadGameObjects();
      return;
    }

    // Is the stage already loaded?
    if (m_scene != null && m_scene.Stage.GetRootLayer().GetIdentifier() == m_usdFile) {
      return;
    }

    // Does the path exist?
    if (!System.IO.File.Exists(m_usdFile)) {
      return;
    }

    // Clear out the old scene.
    UnloadGameObjects();

    // Load the new scene.
    m_scene = Scene.Open(m_usdFile);
    if (m_scene == null) {
      throw new Exception("Failed to load");
    }

    // Set the time at which to read samples from USD.
    m_scene.Time = m_usdTime;

    // Load transforms.
    foreach (var path in m_scene.AllXforms) {
      var xf = new USD.NET.Unity.XformSample();
      m_scene.Read(path, xf);
      var go = new GameObject(path.GetName());
      AssignTransform(xf, go);
      AssignParent(path, go);
    }

    // Load meshes.
    foreach (var path in m_scene.AllMeshes) {
      var mesh = new USD.NET.Unity.MeshSample();
      m_scene.Read(path, mesh);
      var go = new GameObject(path.GetName());
      AssignTransform(mesh, go);
      AssignParent(path, go);
      BuildMesh(mesh, go);
    }

    // Ensure the file and the identifier match.
    m_usdFile = m_scene.Stage.GetRootLayer().GetIdentifier();
  }

  // Convert Matrix4x4 into TSR components.
  void AssignTransform(USD.NET.Unity.XformSample xf, GameObject go) {
    go.transform.localPosition = ExtractPosition(xf.transform);
    go.transform.localScale = ExtractScale(xf.transform);
    go.transform.localRotation = ExtractRotation(xf.transform);
  }

  // Recreate hierarchy.
  void AssignParent(pxr.SdfPath path, GameObject go) {
    m_primMap.Add(path, go);
    if (path.IsRootPrimPath()) {
      return;
    }
    go.transform.SetParent(m_primMap[path.GetParentPath()].transform, worldPositionStays: false);
  }

  // Copy mesh data to Unity and assign mesh with material.
  void BuildMesh(USD.NET.Unity.MeshSample usdMesh, GameObject go) {
    var mf = go.AddComponent<MeshFilter>();
    var mr = go.AddComponent<MeshRenderer>();
    var unityMesh = new UnityEngine.Mesh();

    unityMesh.vertices = usdMesh.points;

    // IMPORTANT: n-gons are not handled, assumes triangle mesh.
    unityMesh.triangles = usdMesh.faceVertexIndices;

    if (usdMesh.extent.size.x > 0 || usdMesh.extent.size.y > 0 || usdMesh.extent.size.z > 0) {
      unityMesh.bounds = usdMesh.extent;
    } else {
      unityMesh.RecalculateBounds();
    }

    if (usdMesh.normals != null) {
      unityMesh.normals = usdMesh.normals;
    } else {
      unityMesh.RecalculateNormals();
    }

    if (usdMesh.tangents != null) {
      unityMesh.tangents = usdMesh.tangents;
    } else {
      unityMesh.RecalculateTangents();
    }

    if (usdMesh.colors != null) { unityMesh.colors = usdMesh.colors; }

    // As in Unity, UVs are a dynamic type which can be vec2, vec3, or vec4.
    if (usdMesh.uv != null) {
      Type uvType = usdMesh.uv.GetType();
      if (uvType == typeof(Vector2[])) {
        unityMesh.SetUVs(0, ((Vector2[])usdMesh.uv).ToList());
      } else if (uvType == typeof(Vector3[])) {
        unityMesh.SetUVs(0, ((Vector3[])usdMesh.uv).ToList());
      } else if (uvType == typeof(Vector4[])) {
        unityMesh.SetUVs(0, ((Vector4[])usdMesh.uv).ToList());
      } else {
        throw new Exception("Unexpected UV type: " + usdMesh.uv.GetType());
      }
    }

    mr.material = m_material;
    mf.mesh = unityMesh;
  }

  // Destroy all previously created objects.
  void UnloadGameObjects() {
    foreach (var kvp in m_primMap) {
      Destroy(kvp.Value);
    }
    m_primMap.Clear();
  }

  // -------------------------------------------------------------------------------------------- //
  // Matrix4x4 helpers, not USD specific.
  // -------------------------------------------------------------------------------------------- //

  static Quaternion ExtractRotation(Matrix4x4 mat4) {
    Vector3 forward;
    forward.x = mat4.m02;
    forward.y = mat4.m12;
    forward.z = mat4.m22;
    Vector3 up;
    up.x = mat4.m01;
    up.y = mat4.m11;
    up.z = mat4.m21;
    return Quaternion.LookRotation(forward, up);
  }

  static Vector3 ExtractPosition(Matrix4x4 mat4) {
    Vector3 position;
    position.x = mat4.m03;
    position.y = mat4.m13;
    position.z = mat4.m23;
    return position;
  }

  static Vector3 ExtractScale(Matrix4x4 mat4) {
    Vector3 scale;
    scale.x = new Vector4(mat4.m00, mat4.m10, mat4.m20, mat4.m30).magnitude;
    scale.y = new Vector4(mat4.m01, mat4.m11, mat4.m21, mat4.m31).magnitude;
    scale.z = new Vector4(mat4.m02, mat4.m12, mat4.m22, mat4.m32).magnitude;
    return scale;
  }
}