//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VectorImage : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<PImage>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorImage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorImage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PapillonPINVOKE.delete_VectorImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VectorImage(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (PImage element in c) {
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

  public PImage this[int index]  {
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

  public void CopyTo(PImage[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(PImage[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, PImage[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<PImage> global::System.Collections.Generic.IEnumerable<PImage>.GetEnumerator() {
    return new VectorImageEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorImageEnumerator(this);
  }

  public VectorImageEnumerator GetEnumerator() {
    return new VectorImageEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorImageEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<PImage>
  {
    private VectorImage collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorImageEnumerator(VectorImage collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public PImage Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (PImage)currentObject;
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
    PapillonPINVOKE.VectorImage_Clear(swigCPtr);
  }

  public void Add(PImage x) {
    PapillonPINVOKE.VectorImage_Add(swigCPtr, PImage.getCPtr(x));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = PapillonPINVOKE.VectorImage_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = PapillonPINVOKE.VectorImage_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    PapillonPINVOKE.VectorImage_reserve(swigCPtr, n);
  }

  public VectorImage() : this(PapillonPINVOKE.new_VectorImage__SWIG_0(), true) {
  }

  public VectorImage(VectorImage other) : this(PapillonPINVOKE.new_VectorImage__SWIG_1(VectorImage.getCPtr(other)), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorImage(int capacity) : this(PapillonPINVOKE.new_VectorImage__SWIG_2(capacity), true) {
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  private PImage getitemcopy(int index) {
    PImage ret = new PImage(PapillonPINVOKE.VectorImage_getitemcopy(swigCPtr, index), true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private PImage getitem(int index) {
    PImage ret = new PImage(PapillonPINVOKE.VectorImage_getitem(swigCPtr, index), false);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, PImage val) {
    PapillonPINVOKE.VectorImage_setitem(swigCPtr, index, PImage.getCPtr(val));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorImage values) {
    PapillonPINVOKE.VectorImage_AddRange(swigCPtr, VectorImage.getCPtr(values));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorImage GetRange(int index, int count) {
    global::System.IntPtr cPtr = PapillonPINVOKE.VectorImage_GetRange(swigCPtr, index, count);
    VectorImage ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorImage(cPtr, true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, PImage x) {
    PapillonPINVOKE.VectorImage_Insert(swigCPtr, index, PImage.getCPtr(x));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorImage values) {
    PapillonPINVOKE.VectorImage_InsertRange(swigCPtr, index, VectorImage.getCPtr(values));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    PapillonPINVOKE.VectorImage_RemoveAt(swigCPtr, index);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    PapillonPINVOKE.VectorImage_RemoveRange(swigCPtr, index, count);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorImage Repeat(PImage value, int count) {
    global::System.IntPtr cPtr = PapillonPINVOKE.VectorImage_Repeat(PImage.getCPtr(value), count);
    VectorImage ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorImage(cPtr, true);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    PapillonPINVOKE.VectorImage_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    PapillonPINVOKE.VectorImage_Reverse__SWIG_1(swigCPtr, index, count);
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorImage values) {
    PapillonPINVOKE.VectorImage_SetRange(swigCPtr, index, VectorImage.getCPtr(values));
    if (PapillonPINVOKE.SWIGPendingException.Pending) throw PapillonPINVOKE.SWIGPendingException.Retrieve();
  }

}