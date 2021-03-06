//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PLog : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PLog(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PLog obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PLog() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PLog(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static string GetPrefix() {
    string ret = PapillonPINVOKE.PLog_GetPrefix();
    return ret;
  }

  public static void SetPrefix(string prefix) {
    PapillonPINVOKE.PLog_SetPrefix(prefix);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static PResult OpenConsoleLogger(PLog.ELogLevel level) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_OpenConsoleLogger__SWIG_0((int)level), true);
    return ret;
  }

  public static PResult OpenConsoleLogger() {
    PResult ret = new PResult(PapillonPINVOKE.PLog_OpenConsoleLogger__SWIG_1(), true);
    return ret;
  }

  public static PResult OpenFileLogger(string loggerName, string destinationFilename, PLog.ELogLevel level, int maximumNumberOfLogs) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_OpenFileLogger__SWIG_0(loggerName, destinationFilename, (int)level, maximumNumberOfLogs), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult OpenFileLogger(string loggerName, string destinationFilename, PLog.ELogLevel level) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_OpenFileLogger__SWIG_1(loggerName, destinationFilename, (int)level), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult OpenFileLogger(string loggerName, string destinationFilename) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_OpenFileLogger__SWIG_2(loggerName, destinationFilename), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Close(string loggerName) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_Close(loggerName), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult CloseConsole() {
    PResult ret = new PResult(PapillonPINVOKE.PLog_CloseConsole(), true);
    return ret;
  }

  public static void DisableConsoleLoggerOnDebug() {
    PapillonPINVOKE.PLog_DisableConsoleLoggerOnDebug();
  }

  public static PResult SetLevel(string loggerName, PLog.ELogLevel level) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_SetLevel(loggerName, (int)level), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult SetConsoleLevel(PLog.ELogLevel level) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_SetConsoleLevel((int)level), true);
    return ret;
  }

  public static PLog.ELogLevel GetLevel(string loggerName) {
    PLog.ELogLevel ret = (PLog.ELogLevel)PapillonPINVOKE.PLog_GetLevel(loggerName);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PLog.ELogLevel GetConsoleLevel() {
    PLog.ELogLevel ret = (PLog.ELogLevel)PapillonPINVOKE.PLog_GetConsoleLevel();
    return ret;
  }

  public static void EnableConsoleLogger() {
    PapillonPINVOKE.PLog_EnableConsoleLogger();
  }

  public static void DisableConsoleLogger() {
    PapillonPINVOKE.PLog_DisableConsoleLogger();
  }

  public static PResult SetFormat(string loggerName, string format) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_SetFormat(loggerName, format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult SetConsoleFormat(string format) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_SetConsoleFormat(format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult SetRegExpFilter(string loggerName, string regExpPattern, PLog.ERegExpPattern syntax) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_SetRegExpFilter__SWIG_0(loggerName, regExpPattern, (int)syntax), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult SetRegExpFilter(string loggerName, string regExpPattern) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_SetRegExpFilter__SWIG_1(loggerName, regExpPattern), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Log(PLog.ELogLevel level, string message, int lineNumber, string filename) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_Log__SWIG_0((int)level, message, lineNumber, filename), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Log(PLog.ELogLevel level, string message, int lineNumber) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_Log__SWIG_1((int)level, message, lineNumber), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Log(PLog.ELogLevel level, string message) {
    PResult ret = new PResult(PapillonPINVOKE.PLog_Log__SWIG_2((int)level, message), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PLog.ELogLevel LogLevelFromString(string stringLevel) {
    PLog.ELogLevel ret = (PLog.ELogLevel)PapillonPINVOKE.PLog_LogLevelFromString(stringLevel);
    return ret;
  }

  public enum ELogLevel {
    E_LEVEL_TRACE = 0,
    E_LEVEL_DEBUG,
    E_LEVEL_INFO,
    E_LEVEL_WARNING,
    E_LEVEL_ERROR,
    E_LEVEL_FATAL
  }

  public enum ERegExpPattern {
    E_REGEXP_PERL,
    E_REGEXP_WILDCARD
  }

}
