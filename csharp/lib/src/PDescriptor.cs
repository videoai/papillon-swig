//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PDescriptor : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PDescriptor(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PDescriptor_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PDescriptor obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PDescriptor() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PDescriptor(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PDescriptor() : this(PapillonPINVOKE.new_PDescriptor__SWIG_0(), true) {
  }

  public PDescriptor(PObjectType objectType, PGuid describerId, PGuid descriptorId) : this(PapillonPINVOKE.new_PDescriptor__SWIG_1(PObjectType.getCPtr(objectType), PGuid.getCPtr(describerId), PGuid.getCPtr(descriptorId)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PDescriptor(PObjectType objectType, PGuid describerId) : this(PapillonPINVOKE.new_PDescriptor__SWIG_2(PObjectType.getCPtr(objectType), PGuid.getCPtr(describerId)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PDescriptor(PDescriptor other) : this(PapillonPINVOKE.new_PDescriptor__SWIG_3(PDescriptor.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PObjectType GetObjectType() {
    PObjectType ret = new PObjectType(PapillonPINVOKE.PDescriptor_GetObjectType(swigCPtr), true);
    return ret;
  }

  public PGuid GetDescribeId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PDescriptor_GetDescribeId(swigCPtr), false);
    return ret;
  }

  public PGuid GetDescriptorId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PDescriptor_GetDescriptorId(swigCPtr), false);
    return ret;
  }

  public void SetDescriptorId(PGuid descriptorId) {
    PapillonPINVOKE.PDescriptor_SetDescriptorId(swigCPtr, PGuid.getCPtr(descriptorId));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PDescriptor_IsEmpty(swigCPtr);
    return ret;
  }

  public void SetDataSourceAsPNGImage(PImage imageDataSource) {
    PapillonPINVOKE.PDescriptor_SetDataSourceAsPNGImage(swigCPtr, PImage.getCPtr(imageDataSource));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PImage GetDataSourceAsImage() {
    PImage ret = new PImage(PapillonPINVOKE.PDescriptor_GetDataSourceAsImage(swigCPtr), true);
    return ret;
  }

  public void SetDescriptor(PByteArray value) {
    PapillonPINVOKE.PDescriptor_SetDescriptor__SWIG_0(swigCPtr, PByteArray.getCPtr(value));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult GetDescriptor(PByteArray value) {
    PResult ret = new PResult(PapillonPINVOKE.PDescriptor_GetDescriptor__SWIG_0(swigCPtr, PByteArray.getCPtr(value)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDescriptor(PObject arg0) {
    PapillonPINVOKE.PDescriptor_SetDescriptor__SWIG_1(swigCPtr, PObject.getCPtr(arg0));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PResult GetDescriptor(PObject arg0) {
    PResult ret = new PResult(PapillonPINVOKE.PDescriptor_GetDescriptor__SWIG_1(swigCPtr, PObject.getCPtr(arg0)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PProperties GetPropertiesShared() {
    PProperties ret = new PProperties(PapillonPINVOKE.PDescriptor_GetPropertiesShared(swigCPtr), true);
    return ret;
  }

  public PProperties GetProperties() {
    PProperties ret = new PProperties(PapillonPINVOKE.PDescriptor_GetProperties(swigCPtr), false);
    return ret;
  }

}
