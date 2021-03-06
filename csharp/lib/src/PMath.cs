//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PMath : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PMath(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PMath obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PMath() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PMath(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static float NaNf() {
    float ret = PapillonPINVOKE.PMath_NaNf();
    return ret;
  }

  public static double NaNd() {
    double ret = PapillonPINVOKE.PMath_NaNd();
    return ret;
  }

  public static int IntMin() {
    int ret = PapillonPINVOKE.PMath_IntMin();
    return ret;
  }

  public static int IntMax() {
    int ret = PapillonPINVOKE.PMath_IntMax();
    return ret;
  }

  public static bool IsNaN(float v) {
    bool ret = PapillonPINVOKE.PMath_IsNaN__SWIG_0(v);
    return ret;
  }

  public static bool IsNaN(double v) {
    bool ret = PapillonPINVOKE.PMath_IsNaN__SWIG_1(v);
    return ret;
  }

  public static int Clamp(int value, int min, int max) {
    int ret = PapillonPINVOKE.PMath_Clamp__SWIG_0(value, min, max);
    return ret;
  }

  public static float Clamp(float value, float min, float max) {
    float ret = PapillonPINVOKE.PMath_Clamp__SWIG_1(value, min, max);
    return ret;
  }

  public static double Clamp(double value, double min, double max) {
    double ret = PapillonPINVOKE.PMath_Clamp__SWIG_2(value, min, max);
    return ret;
  }

  public static double Sigmoid(double x) {
    double ret = PapillonPINVOKE.PMath_Sigmoid(x);
    return ret;
  }

  public static float LERP(float value, float min, float max) {
    float ret = PapillonPINVOKE.PMath_LERP__SWIG_0(value, min, max);
    return ret;
  }

  public static double LERP(double value, double min, double max) {
    double ret = PapillonPINVOKE.PMath_LERP__SWIG_1(value, min, max);
    return ret;
  }

  public static bool RandBool() {
    bool ret = PapillonPINVOKE.PMath_RandBool();
    return ret;
  }

  public static uint RandUInt32() {
    uint ret = PapillonPINVOKE.PMath_RandUInt32();
    return ret;
  }

  public static ulong RandUInt64() {
    ulong ret = PapillonPINVOKE.PMath_RandUInt64();
    return ret;
  }

  public static ulong RandUInt63() {
    ulong ret = PapillonPINVOKE.PMath_RandUInt63();
    return ret;
  }

  public static bool AreAlmostEqual(float v1, float v2, float absoluteError) {
    bool ret = PapillonPINVOKE.PMath_AreAlmostEqual__SWIG_0(v1, v2, absoluteError);
    return ret;
  }

  public static bool AreAlmostEqual(float v1, float v2) {
    bool ret = PapillonPINVOKE.PMath_AreAlmostEqual__SWIG_1(v1, v2);
    return ret;
  }

  public static bool AreAlmostEqual(double v1, double v2, double absoluteError) {
    bool ret = PapillonPINVOKE.PMath_AreAlmostEqual__SWIG_2(v1, v2, absoluteError);
    return ret;
  }

  public static bool AreAlmostEqual(double v1, double v2) {
    bool ret = PapillonPINVOKE.PMath_AreAlmostEqual__SWIG_3(v1, v2);
    return ret;
  }

  public static bool AreAlmostEqualULP(float v1, float v2, int maxULP) {
    bool ret = PapillonPINVOKE.PMath_AreAlmostEqualULP__SWIG_0(v1, v2, maxULP);
    return ret;
  }

  public static bool AreAlmostEqualULP(float v1, float v2) {
    bool ret = PapillonPINVOKE.PMath_AreAlmostEqualULP__SWIG_1(v1, v2);
    return ret;
  }

  public static uint GCD(uint a, uint b) {
    uint ret = PapillonPINVOKE.PMath_GCD(a, b);
    return ret;
  }

  public static bool IsPow2(uint n) {
    bool ret = PapillonPINVOKE.PMath_IsPow2(n);
    return ret;
  }

  public static uint Pow2Up(uint n) {
    uint ret = PapillonPINVOKE.PMath_Pow2Up(n);
    return ret;
  }

  public static uint Pow2Down(uint n) {
    uint ret = PapillonPINVOKE.PMath_Pow2Down(n);
    return ret;
  }

  public static uint Pow2Nearest(uint n) {
    uint ret = PapillonPINVOKE.PMath_Pow2Nearest(n);
    return ret;
  }

  public static bool IsNthBitSet(int value, int n) {
    bool ret = PapillonPINVOKE.PMath_IsNthBitSet(value, n);
    return ret;
  }

  public static int SetNthBit(int value, int n) {
    int ret = PapillonPINVOKE.PMath_SetNthBit(value, n);
    return ret;
  }

  public static int UnsetNthBit(int value, int n) {
    int ret = PapillonPINVOKE.PMath_UnsetNthBit(value, n);
    return ret;
  }

}
