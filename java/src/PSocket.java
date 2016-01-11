/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.5
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class PSocket {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected PSocket(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(PSocket obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        PapillonCoreJavaJNI.delete_PSocket(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public PSocket() {
    this(PapillonCoreJavaJNI.new_PSocket__SWIG_0(), true);
  }

  public static PResult Open(PSocket socket, PSocket.ESocketType socketType, PSocket.ESocketBinding binding, PString endPoint) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Open__SWIG_0(PSocket.getCPtr(socket), socket, socketType.swigValue(), binding.swigValue(), PString.getCPtr(endPoint), endPoint), true);
  }

  public static PResult Open(PSocket socket, PSocket.ESocketType socketType, PSocket.ESocketBinding binding) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Open__SWIG_1(PSocket.getCPtr(socket), socket, socketType.swigValue(), binding.swigValue()), true);
  }

  public static PResult Open(PSocket socket, PSocket.ESocketType socketType) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Open__SWIG_2(PSocket.getCPtr(socket), socket, socketType.swigValue()), true);
  }

  public PSocket(PSocket other) {
    this(PapillonCoreJavaJNI.new_PSocket__SWIG_1(PSocket.getCPtr(other), other), true);
  }

  public PResult Bind(PString endPoint) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Bind(swigCPtr, this, PString.getCPtr(endPoint), endPoint), true);
  }

  public PResult Connnect(PString endPoint) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Connnect(swigCPtr, this, PString.getCPtr(endPoint), endPoint), true);
  }

  public PResult SetLingerPeriod(int periodInMs) {
    return new PResult(PapillonCoreJavaJNI.PSocket_SetLingerPeriod(swigCPtr, this, periodInMs), true);
  }

  public PResult Close() {
    return new PResult(PapillonCoreJavaJNI.PSocket_Close(swigCPtr, this), true);
  }

  public PResult Send(PString message) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Send__SWIG_0(swigCPtr, this, PString.getCPtr(message), message), true);
  }

  public PResult Send(PByteArray message) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Send__SWIG_1(swigCPtr, this, PByteArray.getCPtr(message), message), true);
  }

  public PResult Send(SWIGTYPE_p_void buffer, int lengthInBytes) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Send__SWIG_2(swigCPtr, this, SWIGTYPE_p_void.getCPtr(buffer), lengthInBytes), true);
  }

  public PResult Receive(PString message) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Receive__SWIG_0(swigCPtr, this, PString.getCPtr(message), message), true);
  }

  public PResult Receive(PByteArray message) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Receive__SWIG_1(swigCPtr, this, PByteArray.getCPtr(message), message), true);
  }

  public PResult Receive(SWIGTYPE_p_void buffer, int sizeofBufferInBytes, SWIGTYPE_p_int sizeOfMessageInBytes) {
    return new PResult(PapillonCoreJavaJNI.PSocket_Receive__SWIG_2(swigCPtr, this, SWIGTYPE_p_void.getCPtr(buffer), sizeofBufferInBytes, SWIGTYPE_p_int.getCPtr(sizeOfMessageInBytes)), true);
  }

  public PResult IsPendingIncomingMessage(int timeOutMs) {
    return new PResult(PapillonCoreJavaJNI.PSocket_IsPendingIncomingMessage__SWIG_0(swigCPtr, this, timeOutMs), true);
  }

  public PResult IsPendingIncomingMessage() {
    return new PResult(PapillonCoreJavaJNI.PSocket_IsPendingIncomingMessage__SWIG_1(swigCPtr, this), true);
  }

  public PResult IsPendingOutgoingMessage(int timeOutMs) {
    return new PResult(PapillonCoreJavaJNI.PSocket_IsPendingOutgoingMessage__SWIG_0(swigCPtr, this, timeOutMs), true);
  }

  public PResult IsPendingOutgoingMessage() {
    return new PResult(PapillonCoreJavaJNI.PSocket_IsPendingOutgoingMessage__SWIG_1(swigCPtr, this), true);
  }

  public PString ToString() {
    return new PString(PapillonCoreJavaJNI.PSocket_ToString(swigCPtr, this), true);
  }

  public final static class ESocketType {
    public final static PSocket.ESocketType E_REPLY = new PSocket.ESocketType("E_REPLY");
    public final static PSocket.ESocketType E_REQUEST = new PSocket.ESocketType("E_REQUEST");
    public final static PSocket.ESocketType E_DEALER = new PSocket.ESocketType("E_DEALER");
    public final static PSocket.ESocketType E_ROUTER = new PSocket.ESocketType("E_ROUTER");
    public final static PSocket.ESocketType E_PUBLISHER = new PSocket.ESocketType("E_PUBLISHER");
    public final static PSocket.ESocketType E_SUBSCRIBER = new PSocket.ESocketType("E_SUBSCRIBER");
    public final static PSocket.ESocketType E_PUSH = new PSocket.ESocketType("E_PUSH");
    public final static PSocket.ESocketType E_PULL = new PSocket.ESocketType("E_PULL");
    public final static PSocket.ESocketType E_PAIR = new PSocket.ESocketType("E_PAIR");
    public final static PSocket.ESocketType E_STREAM = new PSocket.ESocketType("E_STREAM");

    public final int swigValue() {
      return swigValue;
    }

    public String toString() {
      return swigName;
    }

    public static ESocketType swigToEnum(int swigValue) {
      if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
        return swigValues[swigValue];
      for (int i = 0; i < swigValues.length; i++)
        if (swigValues[i].swigValue == swigValue)
          return swigValues[i];
      throw new IllegalArgumentException("No enum " + ESocketType.class + " with value " + swigValue);
    }

    private ESocketType(String swigName) {
      this.swigName = swigName;
      this.swigValue = swigNext++;
    }

    private ESocketType(String swigName, int swigValue) {
      this.swigName = swigName;
      this.swigValue = swigValue;
      swigNext = swigValue+1;
    }

    private ESocketType(String swigName, ESocketType swigEnum) {
      this.swigName = swigName;
      this.swigValue = swigEnum.swigValue;
      swigNext = this.swigValue+1;
    }

    private static ESocketType[] swigValues = { E_REPLY, E_REQUEST, E_DEALER, E_ROUTER, E_PUBLISHER, E_SUBSCRIBER, E_PUSH, E_PULL, E_PAIR, E_STREAM };
    private static int swigNext = 0;
    private final int swigValue;
    private final String swigName;
  }

  public final static class ESocketBinding {
    public final static PSocket.ESocketBinding E_UNSPECIFIED = new PSocket.ESocketBinding("E_UNSPECIFIED");
    public final static PSocket.ESocketBinding E_BIND = new PSocket.ESocketBinding("E_BIND");
    public final static PSocket.ESocketBinding E_CONNECT = new PSocket.ESocketBinding("E_CONNECT");

    public final int swigValue() {
      return swigValue;
    }

    public String toString() {
      return swigName;
    }

    public static ESocketBinding swigToEnum(int swigValue) {
      if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
        return swigValues[swigValue];
      for (int i = 0; i < swigValues.length; i++)
        if (swigValues[i].swigValue == swigValue)
          return swigValues[i];
      throw new IllegalArgumentException("No enum " + ESocketBinding.class + " with value " + swigValue);
    }

    private ESocketBinding(String swigName) {
      this.swigName = swigName;
      this.swigValue = swigNext++;
    }

    private ESocketBinding(String swigName, int swigValue) {
      this.swigName = swigName;
      this.swigValue = swigValue;
      swigNext = swigValue+1;
    }

    private ESocketBinding(String swigName, ESocketBinding swigEnum) {
      this.swigName = swigName;
      this.swigValue = swigEnum.swigValue;
      swigNext = this.swigValue+1;
    }

    private static ESocketBinding[] swigValues = { E_UNSPECIFIED, E_BIND, E_CONNECT };
    private static int swigNext = 0;
    private final int swigValue;
    private final String swigName;
  }

}