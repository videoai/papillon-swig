//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PapillonSDK : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PapillonSDK(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PapillonSDK obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PapillonSDK() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PapillonSDK(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static PResult SetLicense(string license) {
    PResult ret = new PResult(PapillonPINVOKE.PapillonSDK_SetLicense(license), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void SetPluginsPath(string pluginsPath) {
    PapillonPINVOKE.PapillonSDK_SetPluginsPath(pluginsPath);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void SetNumberOfThreads(int numberOfThreads) {
    PapillonPINVOKE.PapillonSDK_SetNumberOfThreads(numberOfThreads);
  }

  public static PResult Initialise(int flags) {
    PResult ret = new PResult(PapillonPINVOKE.PapillonSDK_Initialise__SWIG_0(flags), true);
    return ret;
  }

  public static PResult Initialise() {
    PResult ret = new PResult(PapillonPINVOKE.PapillonSDK_Initialise__SWIG_1(), true);
    return ret;
  }

  public static bool IsInitialised() {
    bool ret = PapillonPINVOKE.PapillonSDK_IsInitialised();
    return ret;
  }

  public static PResult Finalise() {
    PResult ret = new PResult(PapillonPINVOKE.PapillonSDK_Finalise(), true);
    return ret;
  }

  public static PVersion GetVersion() {
    PVersion ret = new PVersion(PapillonPINVOKE.PapillonSDK_GetVersion(), true);
    return ret;
  }

  public static void ShowMonitoring() {
    PapillonPINVOKE.PapillonSDK_ShowMonitoring__SWIG_0();
  }

  public static void ShowMonitoring(PProperties parameters) {
    PapillonPINVOKE.PapillonSDK_ShowMonitoring__SWIG_1(PProperties.getCPtr(parameters));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum EPapillonOptions {
    E_NONE = 0,
    E_CONSOLE_LOGGER_INFO_LEVEL = 1,
    E_CONSOLE_LOGGER_DEBUG_LEVEL = 2,
    E_CONSOLE_LOGGER_IF_DEBUG = 4,
    E_DONT_LOAD_PLUGINS = 8,
    E_SILENT_START = 16
  }

}
