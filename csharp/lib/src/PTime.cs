//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PTime : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PTime(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PTime_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PTime obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PTime() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PTime(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PTime(int h, int m, int s, int ms) : this(PapillonPINVOKE.new_PTime__SWIG_0(h, m, s, ms), true) {
  }

  public PTime(int h, int m, int s) : this(PapillonPINVOKE.new_PTime__SWIG_1(h, m, s), true) {
  }

  public PTime(int h, int m) : this(PapillonPINVOKE.new_PTime__SWIG_2(h, m), true) {
  }

  public PTime(int h) : this(PapillonPINVOKE.new_PTime__SWIG_3(h), true) {
  }

  public PTime() : this(PapillonPINVOKE.new_PTime__SWIG_4(), true) {
  }

  public PTime(PTime other) : this(PapillonPINVOKE.new_PTime__SWIG_5(PTime.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PTime(string str, string format) : this(PapillonPINVOKE.new_PTime__SWIG_6(str, format), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PTime(string str) : this(PapillonPINVOKE.new_PTime__SWIG_7(str), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static PTime Current() {
    PTime ret = new PTime(PapillonPINVOKE.PTime_Current(), true);
    return ret;
  }

  public int GetHour() {
    int ret = PapillonPINVOKE.PTime_GetHour(swigCPtr);
    return ret;
  }

  public int GetMinute() {
    int ret = PapillonPINVOKE.PTime_GetMinute(swigCPtr);
    return ret;
  }

  public int GetSecond() {
    int ret = PapillonPINVOKE.PTime_GetSecond(swigCPtr);
    return ret;
  }

  public int GetMillisecond() {
    int ret = PapillonPINVOKE.PTime_GetMillisecond(swigCPtr);
    return ret;
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PTime_IsValid(swigCPtr);
    return ret;
  }

  public PTime AddMillisecond(int n) {
    PTime ret = new PTime(PapillonPINVOKE.PTime_AddMillisecond(swigCPtr, n), true);
    return ret;
  }

  public int GetMillisecondsTo(PTime t) {
    int ret = PapillonPINVOKE.PTime_GetMillisecondsTo(swigCPtr, PTime.getCPtr(t));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(PTime other) {
    int ret = PapillonPINVOKE.PTime_Compare(swigCPtr, PTime.getCPtr(other));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ToString(string format) {
    string ret = PapillonPINVOKE.PTime_ToString__SWIG_0(swigCPtr, format);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new string ToString() {
    string ret = PapillonPINVOKE.PTime_ToString__SWIG_1(swigCPtr);
    return ret;
  }

}
