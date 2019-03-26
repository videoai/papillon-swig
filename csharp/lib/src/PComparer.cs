//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PComparer : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PComparer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PComparer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PComparer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PComparer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PComparer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PComparer() : this(PapillonPINVOKE.new_PComparer__SWIG_0(), true) {
  }

  public PComparer(PComparer other) : this(PapillonPINVOKE.new_PComparer__SWIG_1(PComparer.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static PResult Create(PComparer comparer, double threshold) {
    PResult ret = new PResult(PapillonPINVOKE.PComparer_Create__SWIG_0(PComparer.getCPtr(comparer), threshold), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Create(PComparer comparer) {
    PResult ret = new PResult(PapillonPINVOKE.PComparer_Create__SWIG_1(PComparer.getCPtr(comparer)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Create(PComparer.EComparerType type, PComparer comparer, double threshold) {
    PResult ret = new PResult(PapillonPINVOKE.PComparer_Create__SWIG_2((int)type, PComparer.getCPtr(comparer), threshold), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult Create(PComparer.EComparerType type, PComparer comparer) {
    PResult ret = new PResult(PapillonPINVOKE.PComparer_Create__SWIG_3((int)type, PComparer.getCPtr(comparer)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetName() {
    string ret = PapillonPINVOKE.PComparer_GetName(swigCPtr);
    return ret;
  }

  public PGuid GetId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PComparer_GetId(swigCPtr), true);
    return ret;
  }

  public PResult Compare(PDescription description1, PDescription description2, PMatchScore matchScore) {
    PResult ret = new PResult(PapillonPINVOKE.PComparer_Compare(swigCPtr, PDescription.getCPtr(description1), PDescription.getCPtr(description2), PMatchScore.getCPtr(matchScore)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EComparerType {
    E_COMPARER_VECTOR_CORRELATION,
    E_COMPARER_VECTOR_MEDIAN,
    E_COMPARER_VECTOR_DISTANCE
  }

}