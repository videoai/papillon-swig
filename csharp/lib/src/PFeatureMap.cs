//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PFeatureMap : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PFeatureMap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PFeatureMap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PFeatureMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PFeatureMap() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PFeatureMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PFeatureMap() : this(PapillonPINVOKE.new_PFeatureMap__SWIG_0(), true) {
  }

  public PFeatureMap(PFeatureMap other) : this(PapillonPINVOKE.new_PFeatureMap__SWIG_1(PFeatureMap.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PFeatureMap(PStringMap mapFeaturePoints, PStringMap mapFeatureRectangles) : this(PapillonPINVOKE.new_PFeatureMap__SWIG_2(PStringMap.getCPtr(mapFeaturePoints), PStringMap.getCPtr(mapFeatureRectangles)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    PapillonPINVOKE.PFeatureMap_Clear(swigCPtr);
  }

  public bool IsFeaturePointEmpty() {
    bool ret = PapillonPINVOKE.PFeatureMap_IsFeaturePointEmpty(swigCPtr);
    return ret;
  }

  public bool IsFeatureRectangleEmpty() {
    bool ret = PapillonPINVOKE.PFeatureMap_IsFeatureRectangleEmpty(swigCPtr);
    return ret;
  }

  public int FeaturePointSize() {
    int ret = PapillonPINVOKE.PFeatureMap_FeaturePointSize(swigCPtr);
    return ret;
  }

  public int FeatureRectangleSize() {
    int ret = PapillonPINVOKE.PFeatureMap_FeatureRectangleSize(swigCPtr);
    return ret;
  }

  public void Add(PFeaturePoint p) {
    PapillonPINVOKE.PFeatureMap_Add__SWIG_0(swigCPtr, PFeaturePoint.getCPtr(p));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(PFeatureRectangle p) {
    PapillonPINVOKE.PFeatureMap_Add__SWIG_1(swigCPtr, PFeatureRectangle.getCPtr(p));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddPoint(PFeaturePoint p) {
    PapillonPINVOKE.PFeatureMap_AddPoint(swigCPtr, PFeaturePoint.getCPtr(p));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRectangle(PFeatureRectangle p) {
    PapillonPINVOKE.PFeatureMap_AddRectangle(swigCPtr, PFeatureRectangle.getCPtr(p));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(string name) {
    bool ret = PapillonPINVOKE.PFeatureMap_Remove(swigCPtr, name);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPoint2DfList GetPoints() {
    PPoint2DfList ret = new PPoint2DfList(PapillonPINVOKE.PFeatureMap_GetPoints(swigCPtr), true);
    return ret;
  }

  public PList GetFeaturePoints() {
    PList ret = new PList(PapillonPINVOKE.PFeatureMap_GetFeaturePoints__SWIG_0(swigCPtr), true);
    return ret;
  }

  public bool GetFeaturePointByName(string name, PFeaturePoint o_featurePoint) {
    bool ret = PapillonPINVOKE.PFeatureMap_GetFeaturePointByName__SWIG_0(swigCPtr, name, PFeaturePoint.getCPtr(o_featurePoint));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PFeaturePoint GetFeaturePointByName(string name) {
    PFeaturePoint ret = new PFeaturePoint(PapillonPINVOKE.PFeatureMap_GetFeaturePointByName__SWIG_1(swigCPtr, name), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PList GetFeatureRectangles() {
    PList ret = new PList(PapillonPINVOKE.PFeatureMap_GetFeatureRectangles__SWIG_0(swigCPtr), true);
    return ret;
  }

  public PPoint2Df GetLeftEyeCentre() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PFeatureMap_GetLeftEyeCentre(swigCPtr), true);
    return ret;
  }

  public PPoint2Df GetRightEyeCentre() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PFeatureMap_GetRightEyeCentre(swigCPtr), true);
    return ret;
  }

  public bool GetFeatureRectangleByName(string name, PFeatureRectangle o_featureRectangle) {
    bool ret = PapillonPINVOKE.PFeatureMap_GetFeatureRectangleByName__SWIG_0(swigCPtr, name, PFeatureRectangle.getCPtr(o_featureRectangle));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PFeatureRectangle GetFeatureRectangleByName(string name) {
    PFeatureRectangle ret = new PFeatureRectangle(PapillonPINVOKE.PFeatureMap_GetFeatureRectangleByName__SWIG_1(swigCPtr, name), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PFeatureRectangle GetFaceRectangle() {
    PFeatureRectangle ret = new PFeatureRectangle(PapillonPINVOKE.PFeatureMap_GetFaceRectangle(swigCPtr), true);
    return ret;
  }

  public float GetInterocularDistance() {
    float ret = PapillonPINVOKE.PFeatureMap_GetInterocularDistance(swigCPtr);
    return ret;
  }

  public PStringList GetFeaturePointNames() {
    PStringList ret = new PStringList(PapillonPINVOKE.PFeatureMap_GetFeaturePointNames(swigCPtr), true);
    return ret;
  }

  public PStringList GetFeatureRectangleNames() {
    PStringList ret = new PStringList(PapillonPINVOKE.PFeatureMap_GetFeatureRectangleNames(swigCPtr), true);
    return ret;
  }

  public PRectanglef GetBoundingBox() {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PFeatureMap_GetBoundingBox(swigCPtr), true);
    return ret;
  }

  public PPolygonf GetBoundingPolygon() {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PFeatureMap_GetBoundingPolygon__SWIG_0(swigCPtr), true);
    return ret;
  }

  public PPolygonf GetBoundingPolygon(PStringList listFeatures) {
    PPolygonf ret = new PPolygonf(PapillonPINVOKE.PFeatureMap_GetBoundingPolygon__SWIG_1(swigCPtr, PStringList.getCPtr(listFeatures)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PPoint2Df GetCentreOfMass() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PFeatureMap_GetCentreOfMass__SWIG_0(swigCPtr), true);
    return ret;
  }

  public PPoint2Df GetCentreOfMass(PStringList listFeatures) {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PFeatureMap_GetCentreOfMass__SWIG_1(swigCPtr, PStringList.getCPtr(listFeatures)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFeaturePoints(PStringMap featurePoints) {
    bool ret = PapillonPINVOKE.PFeatureMap_GetFeaturePoints__SWIG_1(swigCPtr, PStringMap.getCPtr(featurePoints));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFeatureRectangles(PStringMap featureRectangles) {
    bool ret = PapillonPINVOKE.PFeatureMap_GetFeatureRectangles__SWIG_1(swigCPtr, PStringMap.getCPtr(featureRectangles));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Translate(float x, float y) {
    PapillonPINVOKE.PFeatureMap_Translate(swigCPtr, x, y);
  }

}
