//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PUInt32 : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PUInt32(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PUInt32_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PUInt32 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PUInt32() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PUInt32(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PUInt32(uint value) : this(PapillonPINVOKE.new_PUInt32__SWIG_0(value), true) {
  }

  public PUInt32() : this(PapillonPINVOKE.new_PUInt32__SWIG_1(), true) {
  }

  public PUInt32(PUInt32 other) : this(PapillonPINVOKE.new_PUInt32__SWIG_2(PUInt32.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetValue() {
    uint ret = PapillonPINVOKE.PUInt32_GetValue(swigCPtr);
    return ret;
  }

}
