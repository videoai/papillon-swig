//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PInt64 : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PInt64(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PInt64_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PInt64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PInt64() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PInt64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PInt64(long value) : this(PapillonPINVOKE.new_PInt64__SWIG_0(value), true) {
  }

  public PInt64() : this(PapillonPINVOKE.new_PInt64__SWIG_1(), true) {
  }

  public PInt64(PInt64 other) : this(PapillonPINVOKE.new_PInt64__SWIG_2(PInt64.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public long GetValue() {
    long ret = PapillonPINVOKE.PInt64_GetValue(swigCPtr);
    return ret;
  }

}
