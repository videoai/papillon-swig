//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PVersion : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PVersion(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PVersion_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PVersion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PVersion() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PVersion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PVersion(int major, int minor, int maintenance, int build) : this(PapillonPINVOKE.new_PVersion__SWIG_0(major, minor, maintenance, build), true) {
  }

  public PVersion(int major, int minor, int maintenance) : this(PapillonPINVOKE.new_PVersion__SWIG_1(major, minor, maintenance), true) {
  }

  public PVersion(int major, int minor) : this(PapillonPINVOKE.new_PVersion__SWIG_2(major, minor), true) {
  }

  public PVersion(int major) : this(PapillonPINVOKE.new_PVersion__SWIG_3(major), true) {
  }

  public PVersion() : this(PapillonPINVOKE.new_PVersion__SWIG_4(), true) {
  }

  public PVersion(string strVersion) : this(PapillonPINVOKE.new_PVersion__SWIG_5(strVersion), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PVersion(PVersion other) : this(PapillonPINVOKE.new_PVersion__SWIG_6(PVersion.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsNull() {
    bool ret = PapillonPINVOKE.PVersion_IsNull(swigCPtr);
    return ret;
  }

  public bool IsDebug() {
    bool ret = PapillonPINVOKE.PVersion_IsDebug(swigCPtr);
    return ret;
  }

  public bool IsRelease() {
    bool ret = PapillonPINVOKE.PVersion_IsRelease(swigCPtr);
    return ret;
  }

  public bool IsX64() {
    bool ret = PapillonPINVOKE.PVersion_IsX64(swigCPtr);
    return ret;
  }

  public bool IsX86() {
    bool ret = PapillonPINVOKE.PVersion_IsX86(swigCPtr);
    return ret;
  }

  public int GetMajor() {
    int ret = PapillonPINVOKE.PVersion_GetMajor(swigCPtr);
    return ret;
  }

  public int GetMinor() {
    int ret = PapillonPINVOKE.PVersion_GetMinor(swigCPtr);
    return ret;
  }

  public int GetMaintenance() {
    int ret = PapillonPINVOKE.PVersion_GetMaintenance(swigCPtr);
    return ret;
  }

  public int GetBuild() {
    int ret = PapillonPINVOKE.PVersion_GetBuild(swigCPtr);
    return ret;
  }

  public int Compare(PVersion other) {
    int ret = PapillonPINVOKE.PVersion_Compare(swigCPtr, PVersion.getCPtr(other));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PVersion Null() {
    PVersion ret = new PVersion(PapillonPINVOKE.PVersion_Null(), false);
    return ret;
  }

  public string ToStringMajorMinor() {
    string ret = PapillonPINVOKE.PVersion_ToStringMajorMinor(swigCPtr);
    return ret;
  }

  public string ToString4Numbers() {
    string ret = PapillonPINVOKE.PVersion_ToString4Numbers(swigCPtr);
    return ret;
  }

}