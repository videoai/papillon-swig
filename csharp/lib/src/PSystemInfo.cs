//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PSystemInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSystemInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSystemInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSystemInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PSystemInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void Log() {
    PapillonPINVOKE.PSystemInfo_Log();
  }

  public static string GetOS() {
    string ret = PapillonPINVOKE.PSystemInfo_GetOS();
    return ret;
  }

  public static string GetArchitecture() {
    string ret = PapillonPINVOKE.PSystemInfo_GetArchitecture();
    return ret;
  }

  public static string GetCPU() {
    string ret = PapillonPINVOKE.PSystemInfo_GetCPU();
    return ret;
  }

  public static string GetCPUInstructionSets() {
    string ret = PapillonPINVOKE.PSystemInfo_GetCPUInstructionSets();
    return ret;
  }

  public static int GetPhysicallyInstalledRAMInMB() {
    int ret = PapillonPINVOKE.PSystemInfo_GetPhysicallyInstalledRAMInMB();
    return ret;
  }

  public static int GetTotalRAM() {
    int ret = PapillonPINVOKE.PSystemInfo_GetTotalRAM();
    return ret;
  }

  public static string GetGPU() {
    string ret = PapillonPINVOKE.PSystemInfo_GetGPU();
    return ret;
  }

  public static string GetMACAddress() {
    string ret = PapillonPINVOKE.PSystemInfo_GetMACAddress();
    return ret;
  }

  public static bool IsCudaCompatibleGPU(int major, int minor) {
    bool ret = PapillonPINVOKE.PSystemInfo_IsCudaCompatibleGPU(major, minor);
    return ret;
  }

  public static void GetMemoryStatistics(ref float currentMemoryUsageMB, ref float peakMemoryUsageMB, ref uint pageFaultCount) {
    PapillonPINVOKE.PSystemInfo_GetMemoryStatistics(ref currentMemoryUsageMB, ref peakMemoryUsageMB, ref pageFaultCount);
  }

  public static void GetPrimaryScreenResolution(SWIGTYPE_p_int width, SWIGTYPE_p_int height) {
    PapillonPINVOKE.PSystemInfo_GetPrimaryScreenResolution(SWIGTYPE_p_int.getCPtr(width), SWIGTYPE_p_int.getCPtr(height));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

}
