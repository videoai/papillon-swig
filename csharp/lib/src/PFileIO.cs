//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PFileIO : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PFileIO(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PFileIO obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PFileIO() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PFileIO(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static PResult WriteToFileWatchlist(string filename, PWatchlist arg1, ESerialisationFormat format) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_WriteToFileWatchlist__SWIG_0(filename, PWatchlist.getCPtr(arg1), (int)format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult WriteToFileWatchlist(string filename, PWatchlist arg1) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_WriteToFileWatchlist__SWIG_1(filename, PWatchlist.getCPtr(arg1)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult ReadFromFileWatchlist(string filename, PWatchlist arg1, ESerialisationFormat format) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_ReadFromFileWatchlist__SWIG_0(filename, PWatchlist.getCPtr(arg1), (int)format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult ReadFromFileWatchlist(string filename, PWatchlist arg1) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_ReadFromFileWatchlist__SWIG_1(filename, PWatchlist.getCPtr(arg1)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult WriteToFile(string filename, PDescription arg1, ESerialisationFormat format) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_WriteToFile__SWIG_2(filename, PDescription.getCPtr(arg1), (int)format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult WriteToFile(string filename, PDescription arg1) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_WriteToFile__SWIG_3(filename, PDescription.getCPtr(arg1)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult ReadFromFile(string filename, PDescription arg1, ESerialisationFormat format) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_ReadFromFile__SWIG_2(filename, PDescription.getCPtr(arg1), (int)format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult ReadFromFile(string filename, PDescription arg1) {
    PResult ret = new PResult(PapillonPINVOKE.PFileIO_ReadFromFile__SWIG_3(filename, PDescription.getCPtr(arg1)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}