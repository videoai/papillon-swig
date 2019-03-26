//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PColour3i : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PColour3i(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PColour3i_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PColour3i obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PColour3i() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PColour3i(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PColour3i(uint colorRGB24) : this(PapillonPINVOKE.new_PColour3i__SWIG_0(colorRGB24), true) {
  }

  public PColour3i(int r, int g, int b) : this(PapillonPINVOKE.new_PColour3i__SWIG_1(r, g, b), true) {
  }

  public PColour3i(int r, int g) : this(PapillonPINVOKE.new_PColour3i__SWIG_2(r, g), true) {
  }

  public PColour3i(int r) : this(PapillonPINVOKE.new_PColour3i__SWIG_3(r), true) {
  }

  public PColour3i() : this(PapillonPINVOKE.new_PColour3i__SWIG_4(), true) {
  }

  public PColour3i(float r, float g, float b) : this(PapillonPINVOKE.new_PColour3i__SWIG_5(r, g, b), true) {
  }

  public PColour3i(string name) : this(PapillonPINVOKE.new_PColour3i__SWIG_6(name), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetR() {
    int ret = PapillonPINVOKE.PColour3i_GetR(swigCPtr);
    return ret;
  }

  public int GetG() {
    int ret = PapillonPINVOKE.PColour3i_GetG(swigCPtr);
    return ret;
  }

  public int GetB() {
    int ret = PapillonPINVOKE.PColour3i_GetB(swigCPtr);
    return ret;
  }

  public void Set(int r, int g, int b) {
    PapillonPINVOKE.PColour3i_Set(swigCPtr, r, g, b);
  }

  public int ToGrey() {
    int ret = PapillonPINVOKE.PColour3i_ToGrey(swigCPtr);
    return ret;
  }

  public void SwapRGB() {
    PapillonPINVOKE.PColour3i_SwapRGB(swigCPtr);
  }

  public void Clamp() {
    PapillonPINVOKE.PColour3i_Clamp(swigCPtr);
  }

  public string ToStringHTML() {
    string ret = PapillonPINVOKE.PColour3i_ToStringHTML(swigCPtr);
    return ret;
  }

  public static PColour3i Aqua() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Aqua(), false);
    return ret;
  }

  public static PColour3i Black() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Black(), false);
    return ret;
  }

  public static PColour3i Blue() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Blue(), false);
    return ret;
  }

  public static PColour3i Brown() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Brown(), false);
    return ret;
  }

  public static PColour3i Coral() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Coral(), false);
    return ret;
  }

  public static PColour3i Darkgray() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Darkgray(), false);
    return ret;
  }

  public static PColour3i Fuschia() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Fuschia(), false);
    return ret;
  }

  public static PColour3i Gray() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Gray(), false);
    return ret;
  }

  public static PColour3i Green() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Green(), false);
    return ret;
  }

  public static PColour3i Lightgray() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Lightgray(), false);
    return ret;
  }

  public static PColour3i Lime() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Lime(), false);
    return ret;
  }

  public static PColour3i Maroon() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Maroon(), false);
    return ret;
  }

  public static PColour3i Navy() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Navy(), false);
    return ret;
  }

  public static PColour3i Olive() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Olive(), false);
    return ret;
  }

  public static PColour3i Orange() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Orange(), false);
    return ret;
  }

  public static PColour3i Pink() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Pink(), false);
    return ret;
  }

  public static PColour3i Purple() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Purple(), false);
    return ret;
  }

  public static PColour3i Red() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Red(), false);
    return ret;
  }

  public static PColour3i Silver() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Silver(), false);
    return ret;
  }

  public static PColour3i Skyblue() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Skyblue(), false);
    return ret;
  }

  public static PColour3i Tan() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Tan(), false);
    return ret;
  }

  public static PColour3i Teal() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Teal(), false);
    return ret;
  }

  public static PColour3i White() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_White(), false);
    return ret;
  }

  public static PColour3i Yellow() {
    PColour3i ret = new PColour3i(PapillonPINVOKE.PColour3i_Yellow(), false);
    return ret;
  }

  public static PColour3i C_COLOUR_TABLE {
    get {
      global::System.IntPtr cPtr = PapillonPINVOKE.PColour3i_C_COLOUR_TABLE_get();
      PColour3i ret = (cPtr == global::System.IntPtr.Zero) ? null : new PColour3i(cPtr, false);
      return ret;
    } 
  }

}