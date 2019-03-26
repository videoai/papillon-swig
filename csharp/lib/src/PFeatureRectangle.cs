//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PFeatureRectangle : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PFeatureRectangle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PFeatureRectangle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PFeatureRectangle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PFeatureRectangle() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PFeatureRectangle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PFeatureRectangle() : this(PapillonPINVOKE.new_PFeatureRectangle__SWIG_0(), true) {
  }

  public PFeatureRectangle(PFeatureRectangle other) : this(PapillonPINVOKE.new_PFeatureRectangle__SWIG_1(PFeatureRectangle.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PFeatureRectangle(PRectanglef rectangle, string description, float confidence) : this(PapillonPINVOKE.new_PFeatureRectangle__SWIG_2(PRectanglef.getCPtr(rectangle), description, confidence), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PFeatureRectangle_IsValid(swigCPtr);
    return ret;
  }

  public PRectanglef GetRectangle() {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PFeatureRectangle_GetRectangle(swigCPtr), false);
    return ret;
  }

  public string GetDescription() {
    string ret = PapillonPINVOKE.PFeatureRectangle_GetDescription(swigCPtr);
    return ret;
  }

  public float GetConfidence() {
    float ret = PapillonPINVOKE.PFeatureRectangle_GetConfidence(swigCPtr);
    return ret;
  }

}
