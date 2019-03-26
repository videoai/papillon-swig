//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PSqlDatabase : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PSqlDatabase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PSqlDatabase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSqlDatabase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSqlDatabase() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PSqlDatabase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PSqlDatabase(PSqlDatabase.EDatabase databaseType) : this(PapillonPINVOKE.new_PSqlDatabase__SWIG_0((int)databaseType), true) {
  }

  public PSqlDatabase() : this(PapillonPINVOKE.new_PSqlDatabase__SWIG_1(), true) {
  }

  public PSqlDatabase(PSqlDatabase other) : this(PapillonPINVOKE.new_PSqlDatabase__SWIG_2(PSqlDatabase.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDriverName() {
    string ret = PapillonPINVOKE.PSqlDatabase_GetDriverName(swigCPtr);
    return ret;
  }

  public static PStringList GetDrivers() {
    PStringList ret = new PStringList(PapillonPINVOKE.PSqlDatabase_GetDrivers(), true);
    return ret;
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PSqlDatabase_IsValid(swigCPtr);
    return ret;
  }

  public void SetHostName(string dbHost) {
    PapillonPINVOKE.PSqlDatabase_SetHostName(swigCPtr, dbHost);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPort(int dbPort) {
    PapillonPINVOKE.PSqlDatabase_SetPort(swigCPtr, dbPort);
  }

  public void SetDatabaseName(string dbName) {
    PapillonPINVOKE.PSqlDatabase_SetDatabaseName(swigCPtr, dbName);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetUserName(string username) {
    PapillonPINVOKE.PSqlDatabase_SetUserName(swigCPtr, username);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPassword(string password) {
    PapillonPINVOKE.PSqlDatabase_SetPassword(swigCPtr, password);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetConnectOptions(string options) {
    PapillonPINVOKE.PSqlDatabase_SetConnectOptions(swigCPtr, options);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult Open(string dbHost, int dbPort, string username, string password) {
    PResult ret = new PResult(PapillonPINVOKE.PSqlDatabase_Open__SWIG_0(swigCPtr, dbHost, dbPort, username, password), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Open(string dbHost, int dbPort, string dbName, string username, string password) {
    PResult ret = new PResult(PapillonPINVOKE.PSqlDatabase_Open__SWIG_1(swigCPtr, dbHost, dbPort, dbName, username, password), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Open() {
    PResult ret = new PResult(PapillonPINVOKE.PSqlDatabase_Open__SWIG_2(swigCPtr), true);
    return ret;
  }

  public void Close() {
    PapillonPINVOKE.PSqlDatabase_Close(swigCPtr);
  }

  public bool IsOpened() {
    bool ret = PapillonPINVOKE.PSqlDatabase_IsOpened(swigCPtr);
    return ret;
  }

  public PStringList ListTables() {
    PStringList ret = new PStringList(PapillonPINVOKE.PSqlDatabase_ListTables(swigCPtr), true);
    return ret;
  }

  public PResult Transaction() {
    PResult ret = new PResult(PapillonPINVOKE.PSqlDatabase_Transaction(swigCPtr), true);
    return ret;
  }

  public PResult Commit() {
    PResult ret = new PResult(PapillonPINVOKE.PSqlDatabase_Commit(swigCPtr), true);
    return ret;
  }

  public PResult Rollback() {
    PResult ret = new PResult(PapillonPINVOKE.PSqlDatabase_Rollback(swigCPtr), true);
    return ret;
  }

  public enum EDatabase {
    E_PSQL,
    E_SQLITE3
  }

}