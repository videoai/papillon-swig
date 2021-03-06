//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PStore : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PStore(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PStore_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PStore obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PStore() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PStore(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PStore() : this(PapillonPINVOKE.new_PStore__SWIG_0(), true) {
  }

  public PStore(PStore other) : this(PapillonPINVOKE.new_PStore__SWIG_1(PStore.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Close() {
    PapillonPINVOKE.PStore_Close(swigCPtr);
  }

  public ulong GetStoreId() {
    ulong ret = PapillonPINVOKE.PStore_GetStoreId(swigCPtr);
    return ret;
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PStore_IsValid(swigCPtr);
    return ret;
  }

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PStore_IsEmpty(swigCPtr);
    return ret;
  }

  public int Size() {
    int ret = PapillonPINVOKE.PStore_Size__SWIG_0(swigCPtr);
    return ret;
  }

  public int Size(EType type) {
    int ret = PapillonPINVOKE.PStore_Size__SWIG_1(swigCPtr, (int)type);
    return ret;
  }

  public bool Exists(PGuid entityId) {
    bool ret = PapillonPINVOKE.PStore_Exists(swigCPtr, PGuid.getCPtr(entityId));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult GetEntity(PGuid entityId, PEntity entity) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_GetEntity(swigCPtr, PGuid.getCPtr(entityId), PEntity.getCPtr(entity)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Get(PGuid entityId, PObject arg1) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_Get(swigCPtr, PGuid.getCPtr(entityId), PObject.getCPtr(arg1)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult GetAll(EType type, PList listObjects) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_GetAll(swigCPtr, (int)type, PList.getCPtr(listObjects)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Add(PObject arg0, PGuid entityId) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_Add__SWIG_0(swigCPtr, PObject.getCPtr(arg0), PGuid.getCPtr(entityId)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Add(PObject arg0) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_Add__SWIG_1(swigCPtr, PObject.getCPtr(arg0)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Update(PGuid entityId, PObject arg1) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_Update(swigCPtr, PGuid.getCPtr(entityId), PObject.getCPtr(arg1)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Remove(PGuid entityId) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_Remove(swigCPtr, PGuid.getCPtr(entityId)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult RemoveAllObjects() {
    PResult ret = new PResult(PapillonPINVOKE.PStore_RemoveAllObjects(swigCPtr), true);
    return ret;
  }

  public PResult SetDeleteFlag(PGuid entityId, bool enabled) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_SetDeleteFlag(swigCPtr, PGuid.getCPtr(entityId), enabled), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PStoreIterator Iterator() {
    PStoreIterator ret = new PStoreIterator(PapillonPINVOKE.PStore_Iterator(swigCPtr), true);
    return ret;
  }

  public void AddListener(SWIGTYPE_p_papillon__PStoreEventListener eventListener) {
    PapillonPINVOKE.PStore_AddListener(swigCPtr, SWIGTYPE_p_papillon__PStoreEventListener.getCPtr(eventListener));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult RemoveListener(SWIGTYPE_p_papillon__PStoreEventListener eventListener) {
    PResult ret = new PResult(PapillonPINVOKE.PStore_RemoveListener(swigCPtr, SWIGTYPE_p_papillon__PStoreEventListener.getCPtr(eventListener)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PDateTime GetTimestampLatestUpdate() {
    PDateTime ret = new PDateTime(PapillonPINVOKE.PStore_GetTimestampLatestUpdate(swigCPtr), true);
    return ret;
  }

  public void SetTimestampLatestUpdate(PDateTime timestamp) {
    PapillonPINVOKE.PStore_SetTimestampLatestUpdate(swigCPtr, PDateTime.getCPtr(timestamp));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

}
