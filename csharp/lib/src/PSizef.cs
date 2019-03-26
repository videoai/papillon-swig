//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PSizef : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PSizef(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PSizef_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSizef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSizef() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PSizef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static PSizef Zero() {
    PSizef ret = new PSizef(PapillonPINVOKE.PSizef_Zero(), false);
    return ret;
  }

  public static PSizef Bad() {
    PSizef ret = new PSizef(PapillonPINVOKE.PSizef_Bad(), false);
    return ret;
  }

  public PSizef() : this(PapillonPINVOKE.new_PSizef__SWIG_0(), true) {
  }

  public PSizef(float s) : this(PapillonPINVOKE.new_PSizef__SWIG_1(s), true) {
  }

  public PSizef(float width, float height) : this(PapillonPINVOKE.new_PSizef__SWIG_2(width, height), true) {
  }

  public PSizef(PSizef other) : this(PapillonPINVOKE.new_PSizef__SWIG_3(PSizef.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PSizef_IsValid(swigCPtr);
    return ret;
  }

  public float GetWidth() {
    float ret = PapillonPINVOKE.PSizef_GetWidth(swigCPtr);
    return ret;
  }

  public float GetHeight() {
    float ret = PapillonPINVOKE.PSizef_GetHeight(swigCPtr);
    return ret;
  }

  public PSizef Scaled(float factor) {
    PSizef ret = new PSizef(PapillonPINVOKE.PSizef_Scaled(swigCPtr, factor), true);
    return ret;
  }

  public PSizef Clamped(float min, float max) {
    PSizef ret = new PSizef(PapillonPINVOKE.PSizef_Clamped(swigCPtr, min, max), true);
    return ret;
  }

  public PSizei ToSizei() {
    PSizei ret = new PSizei(PapillonPINVOKE.PSizef_ToSizei(swigCPtr), true);
    return ret;
  }

  public static PResult FromString(string s, PSizef size) {
    PResult ret = new PResult(PapillonPINVOKE.PSizef_FromString(s, PSizef.getCPtr(size)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ToStringShort() {
    string ret = PapillonPINVOKE.PSizef_ToStringShort(swigCPtr);
    return ret;
  }

}