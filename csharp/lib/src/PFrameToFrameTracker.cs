//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PFrameToFrameTracker : PPluginInstance {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PFrameToFrameTracker(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PFrameToFrameTracker_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PFrameToFrameTracker obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PFrameToFrameTracker() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PFrameToFrameTracker(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static PResult Create(string productName, PProperties parameters, PFrameToFrameTracker frameToFrameTracker) {
    PResult ret = new PResult(PapillonPINVOKE.PFrameToFrameTracker_Create__SWIG_0(productName, PProperties.getCPtr(parameters), PFrameToFrameTracker.getCPtr(frameToFrameTracker)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Create(SWIGTYPE_p_papillon__PPlugin plugin, PProperties parameters, PFrameToFrameTracker frameToFrameTracker) {
    PResult ret = new PResult(PapillonPINVOKE.PFrameToFrameTracker_Create__SWIG_1(SWIGTYPE_p_papillon__PPlugin.getCPtr(plugin), PProperties.getCPtr(parameters), PFrameToFrameTracker.getCPtr(frameToFrameTracker)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PFrameToFrameTracker() : this(PapillonPINVOKE.new_PFrameToFrameTracker__SWIG_0(), true) {
  }

  public PFrameToFrameTracker(PFrameToFrameTracker other) : this(PapillonPINVOKE.new_PFrameToFrameTracker__SWIG_1(PFrameToFrameTracker.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult Apply(PFrame frame, PDetectionList detectionList) {
    PResult ret = new PResult(PapillonPINVOKE.PFrameToFrameTracker_Apply(swigCPtr, PFrame.getCPtr(frame), PDetectionList.getCPtr(detectionList)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
