//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PPluginInstance : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PPluginInstance(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PPluginInstance_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PPluginInstance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PPluginInstance() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PPluginInstance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PPluginInstance() : this(PapillonPINVOKE.new_PPluginInstance__SWIG_0(), true) {
  }

  public PResult Create(SWIGTYPE_p_papillon__PPlugin plugin, PProperties parameters) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Create(swigCPtr, SWIGTYPE_p_papillon__PPlugin.getCPtr(plugin), PProperties.getCPtr(parameters)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPluginInstance(PPluginInstance other) : this(PapillonPINVOKE.new_PPluginInstance__SWIG_1(PPluginInstance.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public global::System.IntPtr GetInstance() {
    global::System.IntPtr ret = PapillonPINVOKE.PPluginInstance_GetInstance(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_papillon__PPlugin GetPlugin() {
    SWIGTYPE_p_papillon__PPlugin ret = new SWIGTYPE_p_papillon__PPlugin(PapillonPINVOKE.PPluginInstance_GetPlugin(swigCPtr), true);
    return ret;
  }

  public PGuid GetPluginId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PPluginInstance_GetPluginId(swigCPtr), true);
    return ret;
  }

  public string GetPluginName() {
    string ret = PapillonPINVOKE.PPluginInstance_GetPluginName(swigCPtr);
    return ret;
  }

  public PGuid GetInstanceId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PPluginInstance_GetInstanceId(swigCPtr), true);
    return ret;
  }

  public string GetInstanceName() {
    string ret = PapillonPINVOKE.PPluginInstance_GetInstanceName(swigCPtr);
    return ret;
  }

  public PResult Get(string property, PObject value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Get__SWIG_0(swigCPtr, property, PObject.getCPtr(value)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Get(string property, ref int value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Get__SWIG_1(swigCPtr, property, ref value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Get(string property, ref long value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Get__SWIG_2(swigCPtr, property, ref value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Get(string property, ref float value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Get__SWIG_3(swigCPtr, property, ref value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Get(string property, ref double value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Get__SWIG_4(swigCPtr, property, ref value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Get(string property, ref bool value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Get__SWIG_5(swigCPtr, property, ref value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Set(string property, PObject value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Set__SWIG_0(swigCPtr, property, PObject.getCPtr(value)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Set(string property, int value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Set__SWIG_1(swigCPtr, property, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Set(string property, long value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Set__SWIG_2(swigCPtr, property, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Set(string property, float value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Set__SWIG_3(swigCPtr, property, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Set(string property, double value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Set__SWIG_4(swigCPtr, property, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Set(string property, bool value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_Set__SWIG_5(swigCPtr, property, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult SetBoolean(string key, bool v) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_SetBoolean(swigCPtr, key, v), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetBoolean(string key) {
    bool ret = PapillonPINVOKE.PPluginInstance_GetBoolean(swigCPtr, key);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult SetInt(string key, int v) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_SetInt(swigCPtr, key, v), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetInt(string key) {
    int ret = PapillonPINVOKE.PPluginInstance_GetInt(swigCPtr, key);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult SetString(string key, string value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_SetString(swigCPtr, key, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetString(string key) {
    string ret = PapillonPINVOKE.PPluginInstance_GetString(swigCPtr, key);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult SetDouble(string key, double value) {
    PResult ret = new PResult(PapillonPINVOKE.PPluginInstance_SetDouble(swigCPtr, key, value), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetDouble(string key) {
    double ret = PapillonPINVOKE.PPluginInstance_GetDouble(swigCPtr, key);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
