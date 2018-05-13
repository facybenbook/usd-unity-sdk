//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdGeomImageable : UsdTyped {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomImageable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomImageable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomImageable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomImageable() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomImageable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomImageable(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomImageable__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomImageable() : this(UsdCsPINVOKE.new_UsdGeomImageable__SWIG_1(), true) {
  }

  public UsdGeomImageable(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdGeomImageable__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomImageable_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomImageable_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomImageable Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomImageable ret = new UsdGeomImageable(UsdCsPINVOKE.UsdGeomImageable_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetVisibilityAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_GetVisibilityAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVisibilityAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_CreateVisibilityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVisibilityAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_CreateVisibilityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVisibilityAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_CreateVisibilityAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetPurposeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_GetPurposeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreatePurposeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_CreatePurposeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePurposeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_CreatePurposeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePurposeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomImageable_CreatePurposeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetProxyPrimRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdGeomImageable_GetProxyPrimRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateProxyPrimRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdGeomImageable_CreateProxyPrimRel(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvar CreatePrimvar(TfToken attrName, SdfValueTypeName typeName, TfToken interpolation, int elementSize) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(UsdCsPINVOKE.UsdGeomImageable_CreatePrimvar__SWIG_0(swigCPtr, TfToken.getCPtr(attrName), SdfValueTypeName.getCPtr(typeName), TfToken.getCPtr(interpolation), elementSize), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar CreatePrimvar(TfToken attrName, SdfValueTypeName typeName, TfToken interpolation) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(UsdCsPINVOKE.UsdGeomImageable_CreatePrimvar__SWIG_1(swigCPtr, TfToken.getCPtr(attrName), SdfValueTypeName.getCPtr(typeName), TfToken.getCPtr(interpolation)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar CreatePrimvar(TfToken attrName, SdfValueTypeName typeName) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(UsdCsPINVOKE.UsdGeomImageable_CreatePrimvar__SWIG_2(swigCPtr, TfToken.getCPtr(attrName), SdfValueTypeName.getCPtr(typeName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar GetPrimvar(TfToken name) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(UsdCsPINVOKE.UsdGeomImageable_GetPrimvar(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvarVector GetPrimvars() {
    UsdGeomPrimvarVector ret = new UsdGeomPrimvarVector(UsdCsPINVOKE.UsdGeomImageable_GetPrimvars(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvarVector GetAuthoredPrimvars() {
    UsdGeomPrimvarVector ret = new UsdGeomPrimvarVector(UsdCsPINVOKE.UsdGeomImageable_GetAuthoredPrimvars(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvarVector FindInheritedPrimvars() {
    UsdGeomPrimvarVector ret = new UsdGeomPrimvarVector(UsdCsPINVOKE.UsdGeomImageable_FindInheritedPrimvars(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvar FindInheritedPrimvar(TfToken name) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(UsdCsPINVOKE.UsdGeomImageable_FindInheritedPrimvar(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasPrimvar(TfToken name) {
    bool ret = UsdCsPINVOKE.UsdGeomImageable_HasPrimvar(swigCPtr, TfToken.getCPtr(name));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasInheritedPrimvar(TfToken name) {
    bool ret = UsdCsPINVOKE.UsdGeomImageable_HasInheritedPrimvar(swigCPtr, TfToken.getCPtr(name));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TfTokenVector GetOrderedPurposeTokens() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomImageable_GetOrderedPurposeTokens(), false);
    return ret;
  }

  public void MakeVisible(UsdTimeCode time) {
    UsdCsPINVOKE.UsdGeomImageable_MakeVisible__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MakeVisible() {
    UsdCsPINVOKE.UsdGeomImageable_MakeVisible__SWIG_1(swigCPtr);
  }

  public void MakeInvisible(UsdTimeCode time) {
    UsdCsPINVOKE.UsdGeomImageable_MakeInvisible__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MakeInvisible() {
    UsdCsPINVOKE.UsdGeomImageable_MakeInvisible__SWIG_1(swigCPtr);
  }

  public TfToken ComputeVisibility(UsdTimeCode time) {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomImageable_ComputeVisibility__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TfToken ComputeVisibility() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomImageable_ComputeVisibility__SWIG_1(swigCPtr), true);
    return ret;
  }

  public TfToken ComputePurpose() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomImageable_ComputePurpose(swigCPtr), true);
    return ret;
  }

  public UsdPrim ComputeProxyPrim(UsdPrim renderPrim) {
    UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdGeomImageable_ComputeProxyPrim__SWIG_0(swigCPtr, UsdPrim.getCPtr(renderPrim)), true);
    return ret;
  }

  public UsdPrim ComputeProxyPrim() {
    UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdGeomImageable_ComputeProxyPrim__SWIG_1(swigCPtr), true);
    return ret;
  }

  public bool SetProxyPrim(UsdPrim proxy) {
    bool ret = UsdCsPINVOKE.UsdGeomImageable_SetProxyPrim__SWIG_0(swigCPtr, UsdPrim.getCPtr(proxy));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetProxyPrim(UsdSchemaBase proxy) {
    bool ret = UsdCsPINVOKE.UsdGeomImageable_SetProxyPrim__SWIG_1(swigCPtr, UsdSchemaBase.getCPtr(proxy));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3, TfToken purpose4) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3), TfToken.getCPtr(purpose4)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeWorldBound(UsdTimeCode time, TfToken purpose1) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_3(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeWorldBound(UsdTimeCode time) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeWorldBound__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3, TfToken purpose4) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3), TfToken.getCPtr(purpose4)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeLocalBound(UsdTimeCode time, TfToken purpose1) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_3(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeLocalBound(UsdTimeCode time) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeLocalBound__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3, TfToken purpose4) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3), TfToken.getCPtr(purpose4)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2, TfToken purpose3) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2), TfToken.getCPtr(purpose3)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1, TfToken purpose2) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_2(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1), TfToken.getCPtr(purpose2)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeUntransformedBound(UsdTimeCode time, TfToken purpose1) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_3(swigCPtr, UsdTimeCode.getCPtr(time), TfToken.getCPtr(purpose1)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfBBox3d ComputeUntransformedBound(UsdTimeCode time) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.UsdGeomImageable_ComputeUntransformedBound__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d ComputeLocalToWorldTransform(UsdTimeCode time) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.UsdGeomImageable_ComputeLocalToWorldTransform(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d ComputeParentToWorldTransform(UsdTimeCode time) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.UsdGeomImageable_ComputeParentToWorldTransform(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly bool IsConcrete = UsdCsPINVOKE.UsdGeomImageable_IsConcrete_get();
  public static readonly bool IsTyped = UsdCsPINVOKE.UsdGeomImageable_IsTyped_get();
}

}
