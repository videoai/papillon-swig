//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PFloat : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PFloat(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PFloat_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PFloat() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PFloat(float value) : this(PapillonPINVOKE.new_PFloat__SWIG_0(value), true) {
  }

  public PFloat() : this(PapillonPINVOKE.new_PFloat__SWIG_1(), true) {
  }

  public PFloat(PFloat other) : this(PapillonPINVOKE.new_PFloat__SWIG_2(PFloat.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetValue() {
    float ret = PapillonPINVOKE.PFloat_GetValue(swigCPtr);
    return ret;
  }

}
