//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PPolygonf : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PPolygonf(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PPolygonf_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PPolygonf obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PPolygonf() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PPolygonf(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PPolygonf(VectorPoint2Df points) : this(PapillonPINVOKE.new_PPolygonf__SWIG_0(VectorPoint2Df.getCPtr(points)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PPolygonf() : this(PapillonPINVOKE.new_PPolygonf__SWIG_1(), true) {
  }

  public PPolygonf(PRectanglef r) : this(PapillonPINVOKE.new_PPolygonf__SWIG_2(PRectanglef.getCPtr(r)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PPolygonf(PPolygonf other) : this(PapillonPINVOKE.new_PPolygonf__SWIG_3(PPolygonf.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    PapillonPINVOKE.PPolygonf_Clear(swigCPtr);
  }

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PPolygonf_IsEmpty(swigCPtr);
    return ret;
  }

  public int Size() {
    int ret = PapillonPINVOKE.PPolygonf_Size(swigCPtr);
    return ret;
  }

  public PPoint2Df GetPoint(int index) {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PPolygonf_GetPoint(swigCPtr, index), true);
    return ret;
  }

  public PPoint2Df GetFirstPoint() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PPolygonf_GetFirstPoint(swigCPtr), true);
    return ret;
  }

  public PPoint2Df GetLastPoint() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PPolygonf_GetLastPoint(swigCPtr), true);
    return ret;
  }

  public PRectanglef GetBoundingRectangle() {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PPolygonf_GetBoundingRectangle(swigCPtr), true);
    return ret;
  }

  public PPolygonf GetConvexHull() {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_GetConvexHull(swigCPtr), true);
    return ret;
  }

  public void SetPoint(int index, PPoint2Df pt) {
    PapillonPINVOKE.PPolygonf_SetPoint(swigCPtr, index, PPoint2Df.getCPtr(pt));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PPolygonf AddPoint(float x, float y, int index) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_AddPoint__SWIG_0(swigCPtr, x, y, index), false);
    return ret;
  }

  public PPolygonf AddPoint(float x, float y) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_AddPoint__SWIG_1(swigCPtr, x, y), false);
    return ret;
  }

  public PPolygonf AddPoint(PPoint2Df p, int index) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_AddPoint__SWIG_2(swigCPtr, PPoint2Df.getCPtr(p), index), false);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPolygonf AddPoint(PPoint2Df p) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_AddPoint__SWIG_3(swigCPtr, PPoint2Df.getCPtr(p)), false);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPolygonf Intersected(PPolygonf other) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_Intersected(swigCPtr, PPolygonf.getCPtr(other)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPolygonf United(PPolygonf other) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_United(swigCPtr, PPolygonf.getCPtr(other)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPolygonf Translated(PPoint2Df v) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PPolygonf_Translated(swigCPtr, PPoint2Df.getCPtr(v)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}