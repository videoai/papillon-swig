//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PImage : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PImage(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PImage() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static int MaxSize() {
    int ret = PapillonPINVOKE.PImage_MaxSize();
    return ret;
  }

  public PImage(int width, int height, PImage.EPixelFormat pixelFormat) : this(PapillonPINVOKE.new_PImage__SWIG_0(width, height, (int)pixelFormat), true) {
  }

  public PImage(int width, int height) : this(PapillonPINVOKE.new_PImage__SWIG_1(width, height), true) {
  }

  public PImage(int width) : this(PapillonPINVOKE.new_PImage__SWIG_2(width), true) {
  }

  public PImage() : this(PapillonPINVOKE.new_PImage__SWIG_3(), true) {
  }

  public PImage(PImage other) : this(PapillonPINVOKE.new_PImage__SWIG_4(PImage.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PImage Clone() {
    PImage ret = new PImage(PapillonPINVOKE.PImage_Clone(swigCPtr), true);
    return ret;
  }

  public void Allocate(int width, int height, PImage.EPixelFormat pixelFormat) {
    PapillonPINVOKE.PImage_Allocate__SWIG_0(swigCPtr, width, height, (int)pixelFormat);
  }

  public void Allocate(int width, int height) {
    PapillonPINVOKE.PImage_Allocate__SWIG_1(swigCPtr, width, height);
  }

  public int GetWidth() {
    int ret = PapillonPINVOKE.PImage_GetWidth(swigCPtr);
    return ret;
  }

  public int GetHeight() {
    int ret = PapillonPINVOKE.PImage_GetHeight(swigCPtr);
    return ret;
  }

  public PRectanglei GetRectangle() {
    PRectanglei ret = new PRectanglei(PapillonPINVOKE.PImage_GetRectangle(swigCPtr), true);
    return ret;
  }

  public PSizei GetSize() {
    PSizei ret = new PSizei(PapillonPINVOKE.PImage_GetSize(swigCPtr), true);
    return ret;
  }

  public PSizei ScaleSize(float scaleFactor) {
    PSizei ret = new PSizei(PapillonPINVOKE.PImage_ScaleSize(swigCPtr, scaleFactor), true);
    return ret;
  }

  public float GetAspectRatio() {
    float ret = PapillonPINVOKE.PImage_GetAspectRatio(swigCPtr);
    return ret;
  }

  public int GetNumberOfChannels() {
    int ret = PapillonPINVOKE.PImage_GetNumberOfChannels(swigCPtr);
    return ret;
  }

  public int GetSizeInBytes() {
    int ret = PapillonPINVOKE.PImage_GetSizeInBytes(swigCPtr);
    return ret;
  }

  public int GetSizeOfRowInBytes() {
    int ret = PapillonPINVOKE.PImage_GetSizeOfRowInBytes(swigCPtr);
    return ret;
  }

  public int GetSizeOfPixelInBytes() {
    int ret = PapillonPINVOKE.PImage_GetSizeOfPixelInBytes(swigCPtr);
    return ret;
  }

  public PImage.EPixelFormat GetPixelFormat() {
    PImage.EPixelFormat ret = (PImage.EPixelFormat)PapillonPINVOKE.PImage_GetPixelFormat(swigCPtr);
    return ret;
  }

  public string GetPixelFormatToString() {
    string ret = PapillonPINVOKE.PImage_GetPixelFormatToString__SWIG_0(swigCPtr);
    return ret;
  }

  public static string GetPixelFormatToString(PImage.EPixelFormat pixelFormat) {
    string ret = PapillonPINVOKE.PImage_GetPixelFormatToString__SWIG_1((int)pixelFormat);
    return ret;
  }

  public static string GetAspectRatioToString(PImage.EAspectRatioMode aspectRatioMode) {
    string ret = PapillonPINVOKE.PImage_GetAspectRatioToString((int)aspectRatioMode);
    return ret;
  }

  public static PImage.EFileFormat GetEFileFormatFromString(string format) {
    PImage.EFileFormat ret = (PImage.EFileFormat)PapillonPINVOKE.PImage_GetEFileFormatFromString(format);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public global::System.IntPtr GetDataPtr(int row) {
  return PapillonPINVOKE.PImage_GetDataPtr__SWIG_0(swigCPtr, row);
}

  public global::System.IntPtr GetDataPtr() {
  return PapillonPINVOKE.PImage_GetDataPtr__SWIG_1(swigCPtr);
}

  public global::System.IntPtr GetPixel(int x, int y) {
  return PapillonPINVOKE.PImage_GetPixel(swigCPtr, x, y);
}

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PImage_IsEmpty(swigCPtr);
    return ret;
  }

  public bool IsGrayscale() {
    bool ret = PapillonPINVOKE.PImage_IsGrayscale(swigCPtr);
    return ret;
  }

  public bool IsSame(PImage other) {
    bool ret = PapillonPINVOKE.PImage_IsSame(swigCPtr, PImage.getCPtr(other));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public unsafe PResult Set(byte[] inputRawBuffer, int width, int height, PImage.EPixelFormat pixelFormat) {
    fixed ( byte* swig_ptrTo_inputRawBuffer = inputRawBuffer ) {
    {
      PResult ret = new PResult(PapillonPINVOKE.PImage_Set(swigCPtr, (global::System.IntPtr)swig_ptrTo_inputRawBuffer, width, height, (int)pixelFormat), true);
      return ret;
    }
    }
  }

  public PResult ExtractSubImage(PImage dest, int x, int y, int width, int height) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_ExtractSubImage__SWIG_0(swigCPtr, PImage.getCPtr(dest), x, y, width, height), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult ExtractSubImage(PImage dest, PRectanglei r) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_ExtractSubImage__SWIG_1(swigCPtr, PImage.getCPtr(dest), PRectanglei.getCPtr(r)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Crop(int x, int y, int width, int height) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Crop__SWIG_0(swigCPtr, x, y, width, height), true);
    return ret;
  }

  public PResult Crop(PRectanglei r) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Crop__SWIG_1(swigCPtr, PRectanglei.getCPtr(r)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult InsertImageInPlace(PImage image, int x, int y) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_InsertImageInPlace(swigCPtr, PImage.getCPtr(image), x, y), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Convert(PImage dest, PImage.EPixelFormat destImageType) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Convert(swigCPtr, PImage.getCPtr(dest), (int)destImageType), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult SwapRGB(PImage dest) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_SwapRGB(swigCPtr, PImage.getCPtr(dest)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, int newWidth, int newHeight, PImage.EAspectRatioMode aspectRatioMode, PImage.EInterpolation interpolation) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_0(swigCPtr, PImage.getCPtr(dest), newWidth, newHeight, (int)aspectRatioMode, (int)interpolation), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, int newWidth, int newHeight, PImage.EAspectRatioMode aspectRatioMode) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_1(swigCPtr, PImage.getCPtr(dest), newWidth, newHeight, (int)aspectRatioMode), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, int newWidth, int newHeight) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_2(swigCPtr, PImage.getCPtr(dest), newWidth, newHeight), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(int newWidth, int newHeight, PImage.EAspectRatioMode aspectRatioMode, PImage.EInterpolation interpolation) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_3(swigCPtr, newWidth, newHeight, (int)aspectRatioMode, (int)interpolation), true);
    return ret;
  }

  public PResult Resize(int newWidth, int newHeight, PImage.EAspectRatioMode aspectRatioMode) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_4(swigCPtr, newWidth, newHeight, (int)aspectRatioMode), true);
    return ret;
  }

  public PResult Resize(int newWidth, int newHeight) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_5(swigCPtr, newWidth, newHeight), true);
    return ret;
  }

  public PResult Resize(PImage dest, PSizei newSize, PImage.EAspectRatioMode aspectRatioMode, PImage.EInterpolation interpolation) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_6(swigCPtr, PImage.getCPtr(dest), PSizei.getCPtr(newSize), (int)aspectRatioMode, (int)interpolation), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, PSizei newSize, PImage.EAspectRatioMode aspectRatioMode) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_7(swigCPtr, PImage.getCPtr(dest), PSizei.getCPtr(newSize), (int)aspectRatioMode), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, PSizei newSize) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_8(swigCPtr, PImage.getCPtr(dest), PSizei.getCPtr(newSize)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PSizei newSize, PImage.EAspectRatioMode aspectRatioMode, PImage.EInterpolation interpolation) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_9(swigCPtr, PSizei.getCPtr(newSize), (int)aspectRatioMode, (int)interpolation), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PSizei newSize, PImage.EAspectRatioMode aspectRatioMode) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_10(swigCPtr, PSizei.getCPtr(newSize), (int)aspectRatioMode), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PSizei newSize) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_11(swigCPtr, PSizei.getCPtr(newSize)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, float scaleFactor, PImage.EInterpolation interpolation) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_12(swigCPtr, PImage.getCPtr(dest), scaleFactor, (int)interpolation), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(PImage dest, float scaleFactor) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_13(swigCPtr, PImage.getCPtr(dest), scaleFactor), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Resize(float scaleFactor, PImage.EInterpolation interpolation) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_14(swigCPtr, scaleFactor, (int)interpolation), true);
    return ret;
  }

  public PResult Resize(float scaleFactor) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Resize__SWIG_15(swigCPtr, scaleFactor), true);
    return ret;
  }

  public PResult EqualizeHistogram(PImage dest) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_EqualizeHistogram(swigCPtr, PImage.getCPtr(dest)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Rotate(PImage dest, int angleInDegrees) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Rotate(swigCPtr, PImage.getCPtr(dest), angleInDegrees), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Blur(PImage dest, int blurFactor) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Blur(swigCPtr, PImage.getCPtr(dest), blurFactor), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    PapillonPINVOKE.PImage_Clear(swigCPtr);
  }

  public PResult Fill(PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Fill(swigCPtr, PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawString(string text, PPoint2Di origin, PImage.EFont font, PColour3i color, double fontScale) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawString__SWIG_0(swigCPtr, text, PPoint2Di.getCPtr(origin), (int)font, PColour3i.getCPtr(color), fontScale), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawString(string text, PPoint2Di origin, PImage.EFont font, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawString__SWIG_1(swigCPtr, text, PPoint2Di.getCPtr(origin), (int)font, PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawString(string text, PPoint2Di origin, string fontName, int fontSize, PColour3i fontColor) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawString__SWIG_2(swigCPtr, text, PPoint2Di.getCPtr(origin), fontName, fontSize, PColour3i.getCPtr(fontColor)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLabel(string text, PPoint2Di centre, PColour3i labelColour, PColour3i textColor, PImage.EFont font, double labelScale) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLabel__SWIG_0(swigCPtr, text, PPoint2Di.getCPtr(centre), PColour3i.getCPtr(labelColour), PColour3i.getCPtr(textColor), (int)font, labelScale), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLabel(string text, PPoint2Di centre, PColour3i labelColour, PColour3i textColor, PImage.EFont font) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLabel__SWIG_1(swigCPtr, text, PPoint2Di.getCPtr(centre), PColour3i.getCPtr(labelColour), PColour3i.getCPtr(textColor), (int)font), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLabel(string text, PPoint2Di centre, PColour3i labelColour, PColour3i textColor) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLabel__SWIG_2(swigCPtr, text, PPoint2Di.getCPtr(centre), PColour3i.getCPtr(labelColour), PColour3i.getCPtr(textColor)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLabel(string text, PPoint2Di centre, PColour3i labelColour) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLabel__SWIG_3(swigCPtr, text, PPoint2Di.getCPtr(centre), PColour3i.getCPtr(labelColour)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLabel(string text, PPoint2Di centre) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLabel__SWIG_4(swigCPtr, text, PPoint2Di.getCPtr(centre)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLine(int x1, int y1, int x2, int y2, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLine__SWIG_0(swigCPtr, x1, y1, x2, y2, PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawLine(int x1, int y1, int x2, int y2, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawLine__SWIG_1(swigCPtr, x1, y1, x2, y2, PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawRectangle(PRectanglei r, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawRectangle__SWIG_0(swigCPtr, PRectanglei.getCPtr(r), PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawRectangle(PRectanglei r, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawRectangle__SWIG_1(swigCPtr, PRectanglei.getCPtr(r), PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawRectangle(PRectanglef r, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawRectangle__SWIG_2(swigCPtr, PRectanglef.getCPtr(r), PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawRectangle(PRectanglef r, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawRectangle__SWIG_3(swigCPtr, PRectanglef.getCPtr(r), PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult FillRectangle(PRectanglei r, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_FillRectangle(swigCPtr, PRectanglei.getCPtr(r), PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawPolygon(PPolygoni p, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawPolygon__SWIG_0(swigCPtr, PPolygoni.getCPtr(p), PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawPolygon(PPolygoni p, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawPolygon__SWIG_1(swigCPtr, PPolygoni.getCPtr(p), PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawPolygon(PPolygonf p, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawPolygon__SWIG_2(swigCPtr, PPolygonf.getCPtr(p), PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawPolygon(PPolygonf p, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawPolygon__SWIG_3(swigCPtr, PPolygonf.getCPtr(p), PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawCircle(PPoint2Df p, int radius, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawCircle__SWIG_0(swigCPtr, PPoint2Df.getCPtr(p), radius, PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawCircle(PPoint2Df p, int radius, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawCircle__SWIG_1(swigCPtr, PPoint2Df.getCPtr(p), radius, PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawCircle(int x, int y, int radius, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawCircle__SWIG_2(swigCPtr, x, y, radius, PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawCircle(int x, int y, int radius, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawCircle__SWIG_3(swigCPtr, x, y, radius, PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawEllipse(int x, int y, int width, int height, PColour3i color, int thickness) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawEllipse__SWIG_0(swigCPtr, x, y, width, height, PColour3i.getCPtr(color), thickness), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DrawEllipse(int x, int y, int width, int height, PColour3i color) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DrawEllipse__SWIG_1(swigCPtr, x, y, width, height, PColour3i.getCPtr(color)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetFingerPrint() {
    string ret = PapillonPINVOKE.PImage_GetFingerPrint(swigCPtr);
    return ret;
  }

  public string ToJpegBase64(int quality) {
    string ret = PapillonPINVOKE.PImage_ToJpegBase64__SWIG_0(swigCPtr, quality);
    return ret;
  }

  public string ToJpegBase64() {
    string ret = PapillonPINVOKE.PImage_ToJpegBase64__SWIG_1(swigCPtr);
    return ret;
  }

  public PResult Load(PByteArray inputBuffer, int offset) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Load__SWIG_0(swigCPtr, PByteArray.getCPtr(inputBuffer), offset), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Load(PByteArray inputBuffer) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Load__SWIG_1(swigCPtr, PByteArray.getCPtr(inputBuffer)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Load(string filename) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Load__SWIG_2(swigCPtr, filename), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult LoadFromBase64(string imageBase64Encoded) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_LoadFromBase64(swigCPtr, imageBase64Encoded), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Save(PByteArray outputBuffer, PImage.EFileFormat format, int quality) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Save__SWIG_0(swigCPtr, PByteArray.getCPtr(outputBuffer), (int)format, quality), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Save(PByteArray outputBuffer, PImage.EFileFormat format) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Save__SWIG_1(swigCPtr, PByteArray.getCPtr(outputBuffer), (int)format), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Save(string filename, int quality) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Save__SWIG_2(swigCPtr, filename, quality), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Save(string filename) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Save__SWIG_3(swigCPtr, filename), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Display(string title, int waitTimeMs) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Display__SWIG_0(swigCPtr, title, waitTimeMs), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Display(string title) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_Display__SWIG_1(swigCPtr, title), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DisplayScaled(string title, int width, int height, int waitTimeMs) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DisplayScaled__SWIG_0(swigCPtr, title, width, height, waitTimeMs), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DisplayScaled(string title, int width, int height) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DisplayScaled__SWIG_1(swigCPtr, title, width, height), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DisplayScaled(string title, int waitTimeMs) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DisplayScaled__SWIG_2(swigCPtr, title, waitTimeMs), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DisplayScaled(string title) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DisplayScaled__SWIG_3(swigCPtr, title), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult DisplayOff(string title) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_DisplayOff(swigCPtr, title), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDisplayPosition(string title, int x, int y) {
    PapillonPINVOKE.PImage_SetDisplayPosition(swigCPtr, title, x, y);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult SetFromCvMat(global::System.IntPtr arg0) {
    PResult ret = new PResult(PapillonPINVOKE.PImage_SetFromCvMat(swigCPtr, arg0), true);
    return ret;
  }

  public enum EPixelFormat {
    E_UNSPECIFIED = 0,
    E_BGR8U,
    E_RGB8U,
    E_BGRA8U,
    E_RGBA8U,
    E_GREY8U,
    E_YCrCb8U,
    E_HSV8U
  }

  public enum EInterpolation {
    E_INTERPOLATION_NEAREST = 0,
    E_INTERPOLATION_LINEAR,
    E_INTERPOLATION_AREA,
    E_INTERPOLATION_CUBIC,
    E_INTERPOLATION_LANCZOS4
  }

  public enum EAspectRatioMode {
    E_IGNORE_ASPECT_RATIO = 0,
    E_KEEP_ASPECT_RATIO,
    E_KEEP_ASPECT_RATIO_BY_EXPANDING,
    E_FIT_MIN_SIZE_WIDTH8_HEIGHT4_ALIGNED,
    E_KEEP_ASPECT_RATIO_FILL_BORDER
  }

  public enum EFont {
    E_FONT_HERSHEY_SIMPLEX = 0,
    E_FONT_HERSHEY_PLAIN = 1,
    E_FONT_HERSHEY_DUPLEX = 2,
    E_FONT_HERSHEY_COMPLEX = 3,
    E_FONT_HERSHEY_TRIPLEX = 4,
    E_FONT_HERSHEY_COMPLEX_SMALL = 5,
    E_FONT_HERSHEY_SCRIPT_SIMPLEX = 6,
    E_FONT_HERSHEY_SCRIPT_COMPLEX = 7
  }

  public enum EFileFormat {
    E_UNKNOWN_FILE_FORMAT = 0,
    E_BMP,
    E_PNG,
    E_JPG,
    E_TIF,
    E_PBM,
    E_PGM,
    E_PPM,
    E_WEBP,
    E_JP2
  }

}
