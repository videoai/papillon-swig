//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PSizei : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PSizei(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PSizei_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSizei obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSizei() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PSizei(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static PSizei Zero() {
    PSizei ret = new PSizei(PapillonPINVOKE.PSizei_Zero(), false);
    return ret;
  }

  public PSizei() : this(PapillonPINVOKE.new_PSizei__SWIG_0(), true) {
  }

  public PSizei(int n) : this(PapillonPINVOKE.new_PSizei__SWIG_1(n), true) {
  }

  public PSizei(int width, int height) : this(PapillonPINVOKE.new_PSizei__SWIG_2(width, height), true) {
  }

  public PSizei(PSizei other) : this(PapillonPINVOKE.new_PSizei__SWIG_3(PSizei.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PSizei_IsValid(swigCPtr);
    return ret;
  }

  public bool IsZero() {
    bool ret = PapillonPINVOKE.PSizei_IsZero(swigCPtr);
    return ret;
  }

  public int GetWidth() {
    int ret = PapillonPINVOKE.PSizei_GetWidth(swigCPtr);
    return ret;
  }

  public int GetHeight() {
    int ret = PapillonPINVOKE.PSizei_GetHeight(swigCPtr);
    return ret;
  }

  public PSizei Scaled(float factor) {
    PSizei ret = new PSizei(PapillonPINVOKE.PSizei_Scaled(swigCPtr, factor), true);
    return ret;
  }

  public PSizei Clamped(int min, int max) {
    PSizei ret = new PSizei(PapillonPINVOKE.PSizei_Clamped(swigCPtr, min, max), true);
    return ret;
  }

  public PSizef ToSizef() {
    PSizef ret = new PSizef(PapillonPINVOKE.PSizei_ToSizef(swigCPtr), true);
    return ret;
  }

  public static PResult FromString(string s, PSizei size) {
    PResult ret = new PResult(PapillonPINVOKE.PSizei_FromString(s, PSizei.getCPtr(size)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ToStringShort() {
    string ret = PapillonPINVOKE.PSizei_ToStringShort(swigCPtr);
    return ret;
  }

}
