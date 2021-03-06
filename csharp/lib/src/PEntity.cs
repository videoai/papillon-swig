//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PEntity : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PEntity(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PEntity_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PEntity obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PEntity() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PEntity(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static string EntityIdPropertyName() {
    string ret = PapillonPINVOKE.PEntity_EntityIdPropertyName();
    return ret;
  }

  public PEntity() : this(PapillonPINVOKE.new_PEntity__SWIG_0(), true) {
  }

  public PEntity(PObject obj) : this(PapillonPINVOKE.new_PEntity__SWIG_1(PObject.getCPtr(obj)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PEntity(PEntity other) : this(PapillonPINVOKE.new_PEntity__SWIG_2(PEntity.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PEntity_IsValid(swigCPtr);
    return ret;
  }

  public PGuid GetEntityId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PEntity_GetEntityId(swigCPtr), true);
    return ret;
  }

  public void SetEntityId(PGuid id) {
    PapillonPINVOKE.PEntity_SetEntityId(swigCPtr, PGuid.getCPtr(id));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStoreId(ulong id) {
    PapillonPINVOKE.PEntity_SetStoreId(swigCPtr, id);
  }

  public ulong GetStoreId() {
    ulong ret = PapillonPINVOKE.PEntity_GetStoreId(swigCPtr);
    return ret;
  }

  public ulong GetObjectId() {
    ulong ret = PapillonPINVOKE.PEntity_GetObjectId(swigCPtr);
    return ret;
  }

  public ushort GetObjectClassId() {
    ushort ret = PapillonPINVOKE.PEntity_GetObjectClassId(swigCPtr);
    return ret;
  }

  public PDateTime GetTimestamp() {
    PDateTime ret = new PDateTime(PapillonPINVOKE.PEntity_GetTimestamp(swigCPtr), true);
    return ret;
  }

  public void SetTimestamp(PDateTime t) {
    PapillonPINVOKE.PEntity_SetTimestamp(swigCPtr, PDateTime.getCPtr(t));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasDeleteFlag() {
    bool ret = PapillonPINVOKE.PEntity_HasDeleteFlag(swigCPtr);
    return ret;
  }

  public void SetDeleteFlag(bool enabled) {
    PapillonPINVOKE.PEntity_SetDeleteFlag(swigCPtr, enabled);
  }

  public PResult GetObject(PObject obj) {
    PResult ret = new PResult(PapillonPINVOKE.PEntity_GetObject(swigCPtr, PObject.getCPtr(obj)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetObject(PObject obj) {
    PapillonPINVOKE.PEntity_SetObject(swigCPtr, PObject.getCPtr(obj));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

}
