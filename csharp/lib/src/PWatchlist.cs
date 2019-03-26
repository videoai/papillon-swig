//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PWatchlist : PObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PWatchlist(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PapillonPINVOKE.PWatchlist_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PWatchlist obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PWatchlist() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_PWatchlist(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PWatchlist() : this(PapillonPINVOKE.new_PWatchlist__SWIG_0(), true) {
  }

  public PWatchlist(PWatchlist other) : this(PapillonPINVOKE.new_PWatchlist__SWIG_1(PWatchlist.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public PGuid GetId() {
    PGuid ret = new PGuid(PapillonPINVOKE.PWatchlist_GetId(swigCPtr), true);
    return ret;
  }

  public void Clear() {
    PapillonPINVOKE.PWatchlist_Clear(swigCPtr);
  }

  public bool IsEmpty() {
    bool ret = PapillonPINVOKE.PWatchlist_IsEmpty(swigCPtr);
    return ret;
  }

  public bool IsCompatibleWith(PGuid describeId) {
    bool ret = PapillonPINVOKE.PWatchlist_IsCompatibleWith(swigCPtr, PGuid.getCPtr(describeId));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Size() {
    int ret = PapillonPINVOKE.PWatchlist_Size(swigCPtr);
    return ret;
  }

  public int GetNumberOfDescriptors() {
    int ret = PapillonPINVOKE.PWatchlist_GetNumberOfDescriptors__SWIG_0(swigCPtr);
    return ret;
  }

  public int GetNumberOfDescriptors(PGuid describerId) {
    int ret = PapillonPINVOKE.PWatchlist_GetNumberOfDescriptors__SWIG_1(swigCPtr, PGuid.getCPtr(describerId));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult GetAllDescribeId(PList ids) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_GetAllDescribeId(swigCPtr, PList.getCPtr(ids)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RecomputeDescriptors(PGuid describeId, PDetector detector, PDescriber describer) {
    int ret = PapillonPINVOKE.PWatchlist_RecomputeDescriptors(swigCPtr, PGuid.getCPtr(describeId), PDetector.getCPtr(detector), PDescriber.getCPtr(describer));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Has(PGuid objectId) {
    bool ret = PapillonPINVOKE.PWatchlist_Has(swigCPtr, PGuid.getCPtr(objectId));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Add(PDescription d) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_Add(swigCPtr, PDescription.getCPtr(d)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Update(PDescription d) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_Update(swigCPtr, PDescription.getCPtr(d)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Remove(PGuid objectId) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_Remove(swigCPtr, PGuid.getCPtr(objectId)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAynchronousUpdater(PIAsynchronousWatchlistUpdater updater, int maxChangesPerSecond) {
    PapillonPINVOKE.PWatchlist_SetAynchronousUpdater__SWIG_0(swigCPtr, PIAsynchronousWatchlistUpdater.getCPtr(updater), maxChangesPerSecond);
  }

  public void SetAynchronousUpdater(PIAsynchronousWatchlistUpdater updater) {
    PapillonPINVOKE.PWatchlist_SetAynchronousUpdater__SWIG_1(swigCPtr, PIAsynchronousWatchlistUpdater.getCPtr(updater));
  }

  public PResult Search(PDescription unknown, PComparer compare, PIdentifyResults results, int topN, float threshold, bool scoreNormalisation) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_Search__SWIG_0(swigCPtr, PDescription.getCPtr(unknown), PComparer.getCPtr(compare), PIdentifyResults.getCPtr(results), topN, threshold, scoreNormalisation), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Search(PDescription unknown, PComparer compare, PIdentifyResults results, int topN, float threshold) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_Search__SWIG_1(swigCPtr, PDescription.getCPtr(unknown), PComparer.getCPtr(compare), PIdentifyResults.getCPtr(results), topN, threshold), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult Search(PDescription unknown, PComparer comparer, PWatchlistOptions options, PIdentifyResults results) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_Search__SWIG_2(swigCPtr, PDescription.getCPtr(unknown), PComparer.getCPtr(comparer), PWatchlistOptions.getCPtr(options), PIdentifyResults.getCPtr(results)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult SetNormalisationDistributions(double meanScorePositive, double meanScoreNegative, double sigmaScorePositive, double sigmaScoreNegative) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_SetNormalisationDistributions(swigCPtr, meanScorePositive, meanScoreNegative, sigmaScorePositive, sigmaScoreNegative), true);
    return ret;
  }

  public PResult GetDescription(PGuid objectId, PDescription description) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_GetDescription(swigCPtr, PGuid.getCPtr(objectId), PDescription.getCPtr(description)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PList GetAllDescriptions() {
    PList ret = new PList(PapillonPINVOKE.PWatchlist_GetAllDescriptions(swigCPtr), true);
    return ret;
  }

  public PList GetIdentityIds() {
    PList ret = new PList(PapillonPINVOKE.PWatchlist_GetIdentityIds(swigCPtr), true);
    return ret;
  }

  public PList FindIdentityIdsByName(string name, PString.ECaseSensitivity caseSensitivity) {
    PList ret = new PList(PapillonPINVOKE.PWatchlist_FindIdentityIdsByName__SWIG_0(swigCPtr, name, (int)caseSensitivity), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PList FindIdentityIdsByName(string name) {
    PList ret = new PList(PapillonPINVOKE.PWatchlist_FindIdentityIdsByName__SWIG_1(swigCPtr, name), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult ReadFromFile(string filename, PWatchlist watchlist) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_ReadFromFile(filename, PWatchlist.getCPtr(watchlist)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PResult ReadFromStore(PStore store, PWatchlist watchlist) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_ReadFromStore(PStore.getCPtr(store), PWatchlist.getCPtr(watchlist)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult WriteToFile(string filename) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_WriteToFile(swigCPtr, filename), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PResult WriteToStore(PStore store) {
    PResult ret = new PResult(PapillonPINVOKE.PWatchlist_WriteToStore(swigCPtr, PStore.getCPtr(store)), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
