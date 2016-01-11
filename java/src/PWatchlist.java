/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.5
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class PWatchlist extends PSerialisationInterface {
  private long swigCPtr;

  protected PWatchlist(long cPtr, boolean cMemoryOwn) {
    super(PapillonCoreJavaJNI.PWatchlist_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(PWatchlist obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        PapillonCoreJavaJNI.delete_PWatchlist(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public PWatchlist() {
    this(PapillonCoreJavaJNI.new_PWatchlist__SWIG_0(), true);
  }

  public PWatchlist(PWatchlist other) {
    this(PapillonCoreJavaJNI.new_PWatchlist__SWIG_1(PWatchlist.getCPtr(other), other), true);
  }

  public static PResult Open(PString filename, PWatchlist watchlist) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Open(PString.getCPtr(filename), filename, PWatchlist.getCPtr(watchlist), watchlist), true);
  }

  public PGuid GetId() {
    return new PGuid(PapillonCoreJavaJNI.PWatchlist_GetId(swigCPtr, this), true);
  }

  public void Clear() {
    PapillonCoreJavaJNI.PWatchlist_Clear(swigCPtr, this);
  }

  public boolean IsEmpty() {
    return PapillonCoreJavaJNI.PWatchlist_IsEmpty(swigCPtr, this);
  }

  public int Size() {
    return PapillonCoreJavaJNI.PWatchlist_Size(swigCPtr, this);
  }

  public PResult Add(PDescription d) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Add(swigCPtr, this, PDescription.getCPtr(d), d), true);
  }

  public PResult Remove(PGuid objectId) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Remove(swigCPtr, this, PGuid.getCPtr(objectId), objectId), true);
  }

  public PResult Search(PDescription unknown, PComparer compare, PIdentifyResults results, int topN, float threshold) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Search(swigCPtr, this, PDescription.getCPtr(unknown), unknown, PComparer.getCPtr(compare), compare, PIdentifyResults.getCPtr(results), results, topN, threshold), true);
  }

  public PResult GetDescription(PGuid objectId, PDescription description) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_GetDescription(swigCPtr, this, PGuid.getCPtr(objectId), objectId, PDescription.getCPtr(description), description), true);
  }

  public SWIGTYPE_p_std__vectorT_papillon__PGuid_t GetIdentityIds() {
    return new SWIGTYPE_p_std__vectorT_papillon__PGuid_t(PapillonCoreJavaJNI.PWatchlist_GetIdentityIds(swigCPtr, this), true);
  }

  public PResult Write(POutputStream os, ESerialisationFormat format) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Write__SWIG_0(swigCPtr, this, POutputStream.getCPtr(os), os, format.swigValue()), true);
  }

  public PResult Write(POutputStream os) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Write__SWIG_1(swigCPtr, this, POutputStream.getCPtr(os), os), true);
  }

  public PResult Read(PInputStream is, ESerialisationFormat format) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Read__SWIG_0(swigCPtr, this, PInputStream.getCPtr(is), is, format.swigValue()), true);
  }

  public PResult Read(PInputStream is) {
    return new PResult(PapillonCoreJavaJNI.PWatchlist_Read__SWIG_1(swigCPtr, this, PInputStream.getCPtr(is), is), true);
  }

  public PString ToString() {
    return new PString(PapillonCoreJavaJNI.PWatchlist_ToString(swigCPtr, this), true);
  }

  public static PClassId getC_CLASSID() {
    long cPtr = PapillonCoreJavaJNI.PWatchlist_C_CLASSID_get();
    return (cPtr == 0) ? null : new PClassId(cPtr, false);
  }

}