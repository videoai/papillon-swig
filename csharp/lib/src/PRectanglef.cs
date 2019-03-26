//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PRectanglef : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PRectanglef(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PRectanglef_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PRectanglef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PRectanglef() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PRectanglef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static PRectanglef Bad() {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Bad(), false);
    return ret;
  }

  public PRectanglef(float x, float y, float w, float h) : this(PapillonPINVOKE.new_PRectanglef__SWIG_0(x, y, w, h), true) {
  }

  public PRectanglef(float x, float y, float w) : this(PapillonPINVOKE.new_PRectanglef__SWIG_1(x, y, w), true) {
  }

  public PRectanglef(float x, float y) : this(PapillonPINVOKE.new_PRectanglef__SWIG_2(x, y), true) {
  }

  public PRectanglef(float x) : this(PapillonPINVOKE.new_PRectanglef__SWIG_3(x), true) {
  }

  public PRectanglef() : this(PapillonPINVOKE.new_PRectanglef__SWIG_4(), true) {
  }

  public PRectanglef(PRectanglef other) : this(PapillonPINVOKE.new_PRectanglef__SWIG_5(PRectanglef.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid() {
    bool ret = PapillonPINVOKE.PRectanglef_IsValid(swigCPtr);
    return ret;
  }

  public float GetX() {
    float ret = PapillonPINVOKE.PRectanglef_GetX(swigCPtr);
    return ret;
  }

  public float GetY() {
    float ret = PapillonPINVOKE.PRectanglef_GetY(swigCPtr);
    return ret;
  }

  public float GetWidth() {
    float ret = PapillonPINVOKE.PRectanglef_GetWidth(swigCPtr);
    return ret;
  }

  public float GetHeight() {
    float ret = PapillonPINVOKE.PRectanglef_GetHeight(swigCPtr);
    return ret;
  }

  public PPoint2Df GetOrigin() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PRectanglef_GetOrigin(swigCPtr), true);
    return ret;
  }

  public PSizef GetSize() {
    PSizef ret = new PSizef(PapillonPINVOKE.PRectanglef_GetSize(swigCPtr), true);
    return ret;
  }

  public PPoint2Df GetCentre() {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.PRectanglef_GetCentre(swigCPtr), true);
    return ret;
  }

  public float GetArea() {
    float ret = PapillonPINVOKE.PRectanglef_GetArea(swigCPtr);
    return ret;
  }

  public float GetOverlapArea(PRectanglef i_rectangle) {
    float ret = PapillonPINVOKE.PRectanglef_GetOverlapArea(swigCPtr, PRectanglef.getCPtr(i_rectangle));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetDiceCoefficient(PRectanglef i_rectangle) {
    float ret = PapillonPINVOKE.PRectanglef_GetDiceCoefficient(swigCPtr, PRectanglef.getCPtr(i_rectangle));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Contains(PPoint2Df p) {
    bool ret = PapillonPINVOKE.PRectanglef_Contains(swigCPtr, PPoint2Df.getCPtr(p));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PRectanglef Expand(float expandBy) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Expand(swigCPtr, expandBy), true);
    return ret;
  }

  public PRectanglef Scaled(float scaleBy) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Scaled__SWIG_0(swigCPtr, scaleBy), true);
    return ret;
  }

  public PRectanglef Scaled(float sx, float sy) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Scaled__SWIG_1(swigCPtr, sx, sy), true);
    return ret;
  }

  public PRectanglef Scaled(PSizef size) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Scaled__SWIG_2(swigCPtr, PSizef.getCPtr(size)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PRectanglef Scaled(PSizei size) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Scaled__SWIG_3(swigCPtr, PSizei.getCPtr(size)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PRectanglef Normalized(float sx, float sy) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Normalized__SWIG_0(swigCPtr, sx, sy), true);
    return ret;
  }

  public PRectanglef Normalized(PSizef size) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Normalized__SWIG_1(swigCPtr, PSizef.getCPtr(size)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PRectanglef Normalized(PSizei size) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Normalized__SWIG_2(swigCPtr, PSizei.getCPtr(size)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PRectanglef Translated(float xTranslateBy, float yTranslateBy) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Translated__SWIG_0(swigCPtr, xTranslateBy, yTranslateBy), true);
    return ret;
  }

  public PRectanglef Translated(PPoint2Df v) {
    PRectanglef ret = new PRectanglef(PapillonPINVOKE.PRectanglef_Translated__SWIG_1(swigCPtr, PPoint2Df.getCPtr(v)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PRectanglei ToPRectanglei() {
    PRectanglei ret = new PRectanglei(PapillonPINVOKE.PRectanglef_ToPRectanglei(swigCPtr), true);
    return ret;
  }

}
