//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PWatchlistOptions : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PWatchlistOptions(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PWatchlistOptions_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PWatchlistOptions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PWatchlistOptions() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PWatchlistOptions(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PWatchlistOptions() : this(PapillonPINVOKE.new_PWatchlistOptions__SWIG_0(), true) {
  }

  public PWatchlistOptions(float threshold, int topN, bool normalisation, PProperties additionalParameters) : this(PapillonPINVOKE.new_PWatchlistOptions__SWIG_1(threshold, topN, normalisation, PProperties.getCPtr(additionalParameters)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PWatchlistOptions(PWatchlistOptions other) : this(PapillonPINVOKE.new_PWatchlistOptions__SWIG_2(PWatchlistOptions.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reset() {
    PapillonPINVOKE.PWatchlistOptions_Reset(swigCPtr);
  }

  public PResult SetThreshold(float threshold) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlistOptions_SetThreshold(swigCPtr, threshold), true);
    return ret;
  }

  public float GetThreshold() {
    float ret = PapillonPINVOKE.PWatchlistOptions_GetThreshold(swigCPtr);
    return ret;
  }

  public PResult SetTopN(int topN) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlistOptions_SetTopN(swigCPtr, topN), true);
    return ret;
  }

  public int GetTopN() {
    int ret = PapillonPINVOKE.PWatchlistOptions_GetTopN(swigCPtr);
    return ret;
  }

  public void SetNormalise(bool normalise) {
    PapillonPINVOKE.PWatchlistOptions_SetNormalise(swigCPtr, normalise);
  }

  public bool GetNormalise() {
    bool ret = PapillonPINVOKE.PWatchlistOptions_GetNormalise(swigCPtr);
    return ret;
  }

  public PResult SetParameter(string parameterName, PObject value) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlistOptions_SetParameter(swigCPtr, parameterName, PObject.getCPtr(value)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult GetParameter(string parameterName, PObject value) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlistOptions_GetParameter(swigCPtr, parameterName, PObject.getCPtr(value)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
