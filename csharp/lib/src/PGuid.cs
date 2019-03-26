//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PGuid : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PGuid(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PGuid_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PGuid obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PGuid() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PGuid(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static ulong UndefinedPartId() {
    ulong ret = PapillonPINVOKE.PGuid_UndefinedPartId();
    return ret;
  }

  public static PGuid Null() {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_Null(), false);
    return ret;
  }

  public static PGuid Undefined() {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_Undefined(), false);
    return ret;
  }

  public static PGuid Invalid() {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_Invalid(), false);
    return ret;
  }

  public PGuid() : this(PapillonPINVOKE.new_PGuid__SWIG_0(), true) {
  }

  public PGuid(PGuid other) : this(PapillonPINVOKE.new_PGuid__SWIG_1(PGuid.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PGuid(string str) : this(PapillonPINVOKE.new_PGuid__SWIG_2(str), true) {
  }

  public PGuid(global::System.IntPtr buffer) : this(PapillonPINVOKE.new_PGuid__SWIG_4(buffer), true) {
  }

  public PGuid(ulong storeId, ulong objectId) : this(PapillonPINVOKE.new_PGuid__SWIG_5(storeId, objectId), true) {
  }

  public static PGuid CreateUniqueId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_CreateUniqueId(), true);
    return ret;
  }

  public static PGuid CreateEntityId(ulong storeId) {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_CreateEntityId__SWIG_0(storeId), true);
    return ret;
  }

  public static PGuid CreateEntityId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_CreateEntityId__SWIG_1(), true);
    return ret;
  }

  public static PGuid CreateFromMD5(string str) {
    PGuid ret = new PGuid(PapillonPINVOKE.PGuid_CreateFromMD5(str), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsNull() {
    bool ret = PapillonPINVOKE.PGuid_IsNull(swigCPtr);
    return ret;
  }

  public bool IsUndefined() {
    bool ret = PapillonPINVOKE.PGuid_IsUndefined(swigCPtr);
    return ret;
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PGuid_IsValid(swigCPtr);
    return ret;
  }

  public bool IsInvalid() {
    bool ret = PapillonPINVOKE.PGuid_IsInvalid(swigCPtr);
    return ret;
  }

  public bool IsNullStoreId() {
    bool ret = PapillonPINVOKE.PGuid_IsNullStoreId(swigCPtr);
    return ret;
  }

  public bool IsUndefinedStoreId() {
    bool ret = PapillonPINVOKE.PGuid_IsUndefinedStoreId(swigCPtr);
    return ret;
  }

  public ulong GetStoreId() {
    ulong ret = PapillonPINVOKE.PGuid_GetStoreId(swigCPtr);
    return ret;
  }

  public bool IsNullObjectId() {
    bool ret = PapillonPINVOKE.PGuid_IsNullObjectId(swigCPtr);
    return ret;
  }

  public bool IsUndefinedObjectId() {
    bool ret = PapillonPINVOKE.PGuid_IsUndefinedObjectId(swigCPtr);
    return ret;
  }

  public ulong GetObjectId() {
    ulong ret = PapillonPINVOKE.PGuid_GetObjectId(swigCPtr);
    return ret;
  }

}
