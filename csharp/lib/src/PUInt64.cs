//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PUInt64 : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PUInt64(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PUInt64_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PUInt64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PUInt64() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PUInt64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PUInt64(ulong value) : this(PapillonPINVOKE.new_PUInt64__SWIG_0(value), true) {
  }

  public PUInt64() : this(PapillonPINVOKE.new_PUInt64__SWIG_1(), true) {
  }

  public PUInt64(PUInt64 other) : this(PapillonPINVOKE.new_PUInt64__SWIG_2(PUInt64.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong GetValue() {
    ulong ret = PapillonPINVOKE.PUInt64_GetValue(swigCPtr);
    return ret;
  }

}