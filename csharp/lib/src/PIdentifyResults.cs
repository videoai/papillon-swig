//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PIdentifyResults : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PIdentifyResults(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PIdentifyResults_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PIdentifyResults obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PIdentifyResults() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PIdentifyResults(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PIdentifyResults() : this(PapillonPINVOKE.new_PIdentifyResults__SWIG_0(), true) {
  }

  public PIdentifyResults(PIdentifyResults other) : this(PapillonPINVOKE.new_PIdentifyResults__SWIG_1(PIdentifyResults.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PIdentifyResults Clone() {
    PIdentifyResults ret = new PIdentifyResults(PapillonPINVOKE.PIdentifyResults_Clone(swigCPtr), true);
    return ret;
  }

  public void Clear() {
    PapillonPINVOKE.PIdentifyResults_Clear(swigCPtr);
  }

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PIdentifyResults_IsEmpty(swigCPtr);
    return ret;
  }

  public int Size() {
    int ret = PapillonPINVOKE.PIdentifyResults_Size(swigCPtr);
    return ret;
  }

  public void Add(PIdentifyResult r) {
    PapillonPINVOKE.PIdentifyResults_Add(swigCPtr, PIdentifyResult.getCPtr(r));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult Remove(int n) {
    PResult ret = new PResult(PapillonPINVOKE.PIdentifyResults_Remove(swigCPtr, n), true);
    return ret;
  }

  public PIdentifyResult Get(int n) {
    PIdentifyResult ret = new PIdentifyResult(PapillonPINVOKE.PIdentifyResults_Get(swigCPtr, n), true);
    return ret;
  }

  public double GetThreshold() {
    double ret = PapillonPINVOKE.PIdentifyResults_GetThreshold(swigCPtr);
    return ret;
  }

  public int GetNumberOfMatches() {
    int ret = PapillonPINVOKE.PIdentifyResults_GetNumberOfMatches(swigCPtr);
    return ret;
  }

  public PIdentifyResults GetResults() {
    PIdentifyResults ret = new PIdentifyResults(PapillonPINVOKE.PIdentifyResults_GetResults(swigCPtr), true);
    return ret;
  }

  public void SetThreshold(double threshold) {
    PapillonPINVOKE.PIdentifyResults_SetThreshold(swigCPtr, threshold);
  }

}