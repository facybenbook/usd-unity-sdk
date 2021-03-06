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

public class UsdSkelPackedJointAnimation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelPackedJointAnimation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelPackedJointAnimation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelPackedJointAnimation() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelPackedJointAnimation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelPackedJointAnimation(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdSkelPackedJointAnimation__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdSkelPackedJointAnimation() : this(UsdCsPINVOKE.new_UsdSkelPackedJointAnimation__SWIG_1(), true) {
  }

  public UsdSkelPackedJointAnimation(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdSkelPackedJointAnimation__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdSkelPackedJointAnimation Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdSkelPackedJointAnimation ret = new UsdSkelPackedJointAnimation(UsdCsPINVOKE.UsdSkelPackedJointAnimation_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdSkelPackedJointAnimation Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdSkelPackedJointAnimation ret = new UsdSkelPackedJointAnimation(UsdCsPINVOKE.UsdSkelPackedJointAnimation_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
