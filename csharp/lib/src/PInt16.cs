//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PInt16 : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PInt16(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PInt16_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PInt16 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PInt16() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PInt16(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PInt16(short value) : this(PapillonPINVOKE.new_PInt16__SWIG_0(value), true) {
  }

  public PInt16() : this(PapillonPINVOKE.new_PInt16__SWIG_1(), true) {
  }

  public PInt16(PInt16 other) : this(PapillonPINVOKE.new_PInt16__SWIG_2(PInt16.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public short GetValue() {
    short ret = PapillonPINVOKE.PInt16_GetValue(swigCPtr);
    return ret;
  }

}
