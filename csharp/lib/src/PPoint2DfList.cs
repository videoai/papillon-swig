//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PPoint2DfList : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PPoint2DfList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PPoint2DfList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PPoint2DfList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PPoint2DfList() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PPoint2DfList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PPoint2DfList() : this(PapillonPINVOKE.new_PPoint2DfList__SWIG_0(), true) {
  }

  public PPoint2DfList(PPoint2DfList other) : this(PapillonPINVOKE.new_PPoint2DfList__SWIG_1(PPoint2DfList.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    PapillonPINVOKE.PPoint2DfList_Clear(swigCPtr);
  }

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PPoint2DfList_IsEmpty(swigCPtr);
    return ret;
  }

  public int Size() {
    int ret = PapillonPINVOKE.PPoint2DfList_Size(swigCPtr);
    return ret;
  }

  public void Add(PPoint2Df p) {
    PapillonPINVOKE.PPoint2DfList_Add(swigCPtr, PPoint2Df.getCPtr(p));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PPoint2Df Get(int n) {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PPoint2DfList_Get(swigCPtr, n), true);
    return ret;
  }

}
