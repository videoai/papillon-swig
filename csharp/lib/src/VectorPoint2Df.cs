//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VectorPoint2Df : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<PPoint2Df>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorPoint2Df(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorPoint2Df obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorPoint2Df() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_VectorPoint2Df(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VectorPoint2Df(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (PPoint2Df element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public PPoint2Df this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(PPoint2Df[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(PPoint2Df[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, PPoint2Df[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<PPoint2Df> global::System.Collections.Generic.IEnumerable<PPoint2Df>.GetEnumerator() {
    return new VectorPoint2DfEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorPoint2DfEnumerator(this);
  }

  public VectorPoint2DfEnumerator GetEnumerator() {
    return new VectorPoint2DfEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorPoint2DfEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<PPoint2Df>
  {
    private VectorPoint2Df collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorPoint2DfEnumerator(VectorPoint2Df collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public PPoint2Df Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (PPoint2Df)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    PapillonPINVOKE.VectorPoint2Df_Clear(swigCPtr);
  }

  public void Add(PPoint2Df x) {
    PapillonPINVOKE.VectorPoint2Df_Add(swigCPtr, PPoint2Df.getCPtr(x));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = PapillonPINVOKE.VectorPoint2Df_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = PapillonPINVOKE.VectorPoint2Df_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    PapillonPINVOKE.VectorPoint2Df_reserve(swigCPtr, n);
  }

  public VectorPoint2Df() : this(PapillonPINVOKE.new_VectorPoint2Df__SWIG_0(), true) {
  }

  public VectorPoint2Df(VectorPoint2Df other) : this(PapillonPINVOKE.new_VectorPoint2Df__SWIG_1(VectorPoint2Df.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorPoint2Df(int capacity) : this(PapillonPINVOKE.new_VectorPoint2Df__SWIG_2(capacity), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  private PPoint2Df getitemcopy(int index) {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.VectorPoint2Df_getitemcopy(swigCPtr, index), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private PPoint2Df getitem(int index) {
    PPoint2Df ret = new PPoint2Df(PapillonPINVOKE.VectorPoint2Df_getitem(swigCPtr, index), false);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, PPoint2Df val) {
    PapillonPINVOKE.VectorPoint2Df_setitem(swigCPtr, index, PPoint2Df.getCPtr(val));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorPoint2Df values) {
    PapillonPINVOKE.VectorPoint2Df_AddRange(swigCPtr, VectorPoint2Df.getCPtr(values));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorPoint2Df GetRange(int index, int count) {
    global::System.IntPtr cPtr = PapillonPINVOKE.VectorPoint2Df_GetRange(swigCPtr, index, count);
    VectorPoint2Df ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorPoint2Df(cPtr, true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, PPoint2Df x) {
    PapillonPINVOKE.VectorPoint2Df_Insert(swigCPtr, index, PPoint2Df.getCPtr(x));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorPoint2Df values) {
    PapillonPINVOKE.VectorPoint2Df_InsertRange(swigCPtr, index, VectorPoint2Df.getCPtr(values));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    PapillonPINVOKE.VectorPoint2Df_RemoveAt(swigCPtr, index);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    PapillonPINVOKE.VectorPoint2Df_RemoveRange(swigCPtr, index, count);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorPoint2Df Repeat(PPoint2Df value, int count) {
    global::System.IntPtr cPtr = PapillonPINVOKE.VectorPoint2Df_Repeat(PPoint2Df.getCPtr(value), count);
    VectorPoint2Df ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorPoint2Df(cPtr, true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    PapillonPINVOKE.VectorPoint2Df_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    PapillonPINVOKE.VectorPoint2Df_Reverse__SWIG_1(swigCPtr, index, count);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorPoint2Df values) {
    PapillonPINVOKE.VectorPoint2Df_SetRange(swigCPtr, index, VectorPoint2Df.getCPtr(values));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

}