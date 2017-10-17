#ifdef SWIGJAVA
%module PapillonJava
#else
%module Papillon
#endif

%{
#define SWIG_FILE_WITH_INIT
%}

%include <std_string.i>
%include <std_vector.i>
%include <std_shared_ptr.i>

#ifdef WITH_PYTHON_NUMPY
%include <numpy.i>
%init %{
import_array();
%}
#endif


// Make sure int64 gets defined properly
%include <stdint.i>

#ifndef SWIGGO
%include <std_wstring.i>
#endif

%{
#include <PapillonCore.h>
//#include <PSUpervisor.h>
%}

#define PAPILLON_API_CORE
#define PAPILLON_API_REMOTE_MONITORING
#define FORCEINLINE
#pragma SWIG nowarn=503 // the operator<<
#pragma SWIG nowarn=361 // the operator!
#pragma SWIG nowarn=362 // the operator=

#ifdef SWIGPYTHON
        
        %extend papillon::PString
        {
          const char *__str__()
          {
            return self->c_str();
          }
        }

        %typemap(in) const papillon::PString &
        {
         if (PyString_Check($input)) {
            $1 = new papillon::PString(PyString_AsString($input));
          }
          else if  (PyUnicode_Check($input)) {
            PyObject *obj = PyUnicode_AsEncodedString($input, "utf-8", "Error ~");
            $1 = new papillon::PString((char*)PyBytes_AS_STRING(obj));
          }
         else
         {
           PyErr_SetString(PyExc_TypeError,"Expected a string.");
           return NULL;
         }
        }
        
        %typemap(out) papillon::PString
        {
          $result = PyString_FromStringAndSize($1.c_str(), $1.Size());
        }

        %typemap(typecheck) const papillon::PString & = PyObject *;
    

        %extend papillon::PByteArray {
			std::vector<double> ToDoubleVector() {
				int length = self->Size() / sizeof(double);
				std::vector<double>vec;
				vec.resize(length);
				memcpy(&vec[0], self->AsPtr<double>(), self->Size());
				return vec;
			}
        }
       
        %extend papillon::PDescriptor {
			std::vector<double> ToDoubleVector() {
				papillon::PByteArray ba;
				self->GetDescriptor(ba);
				int length = ba.Size() / sizeof(double);
				std::vector<double>vec;
				vec.resize(length);
				memcpy(&vec[0], ba.AsPtr<double>(), ba.Size());
				return vec;
			}
        }

#ifdef WITH_PYTHON_NUMPY
        %extend papillon::PByteArray {
			PyObject * ToDoubleNumPyArray() {
				int length = self->Size() / sizeof(double);
				double * p = self->AsPtr<double>();
				npy_intp dims[1];
				dims[0]=length;
				return PyArray_SimpleNewFromData(1, dims, NPY_DOUBLE, (void*)p);
			}
        }

        %extend papillon::PDescriptor {
			PyObject * ToDoubleNumPyArray() {
				papillon::PByteArray ba;
				self->GetDescriptor(ba);
				int length = ba.Size() / sizeof(double);
				double * p = ba.AsPtr<double>();
				npy_intp dims[1];
				dims[0]=length;
				return PyArray_SimpleNewFromData(1, dims, NPY_DOUBLE, (void*)p);
			}
        }
#endif

		namespace std {
			%template(VectorDouble) vector<double>;
		}
        
#endif

#ifdef SWIGCSHARP

%apply void *VOID_INT_PTR { void * }

%include <std_wstring.i>
%include <typemaps.i>
%include <arrays_csharp.i>

%csmethodmodifiers papillon::PImage::Set "public unsafe";
%apply unsigned char FIXED[] {void * inputRawBuffer}
// This is the safe version of above
//%apply byte INPUT[] {void * inputRawBuffer}


%apply int &INOUT {int &value}
%apply bool &INOUT {bool &value}
%apply double &INOUT {double &value}
%apply float &INOUT {float &value}
%apply long long &INOUT {long long & value}

%apply bool *INOUT {bool *ok}

%apply int *INOUT {int *year}
%apply int *INOUT {int *month}
%apply int *INOUT {int *day}

%apply int *INOUT {int &version}

%apply int &INOUT {int &sizeOfMessageInBytes}

%apply float &INOUT {float &currentMemoryUsageMB}
%apply float &INOUT {float &peakMemoryUsageMB}
%apply unsigned int &INOUT {unsigned int &pageFaultCount}

%typemap(ctype) unsigned char *, unsigned char[ANY], unsigned char[]
"unsigned char *"

%typemap(imtype) unsigned char *, unsigned char[ANY], unsigned char[]
"global::System.IntPtr"

%typemap(cstype) unsigned char *, unsigned char[ANY], unsigned char[]
"global::System.IntPtr"

%typemap(in) unsigned char *, unsigned char[ANY], unsigned char[] %{ $1
= $input; %}

%typemap(out) unsigned char *, unsigned char[ANY], unsigned char[] %{
$result = $1; %}

%typemap(csin) unsigned char *, unsigned char[ANY], unsigned char[]
"$csinput"

%typemap(csout) unsigned char *, unsigned char[ANY], unsigned char[] {
  return $imcall;
}

%typemap(csvarin) unsigned char *, unsigned char[ANY], unsigned char[]
%{
  set {
    $imcall;
  } %}

%typemap(csvarout) unsigned char *, unsigned char[ANY], unsigned char[]
%{
  get {
    return new(global::System.IntPtr((int)$imcall);
  } %} 




namespace papillon {


class PString;



////////////
// PString
////////////
%typemap(ctype) PString "char *"
%typemap(imtype) PString "string"
%typemap(cstype) PString "string"

%typemap(csdirectorin) PString "$iminput"
%typemap(csdirectorout) PString "$cscall"

%typemap(in, canthrow=1) PString 
%{ if (!$input) {
    SWIG_CSharpSetPendingExceptionArgument(SWIG_CSharpArgumentNullException, "null PString", 0);
    return $null;
   }
   $1 = PString($input); %}
  
%typemap(out) PString %{ $result = SWIG_csharp_string_callback($1.ToString().c_str()); %}

%typemap(directorout, canthrow=1) PString
%{ if (!$input) {
    SWIG_CSharpSetPendingExceptionArgument(SWIG_CSharpArgumentNullException, "null string", 0);
    return $null;
   }
   $result = PString($input);  
%}

%typemap(directorin) PString %{ $input = SWIG_csharp_string_callback($1.ToString().c_str()); %}


%typemap(csin) PString "$csinput"
%typemap(csout, excode=SWIGEXCODE) PString {
    string ret = $imcall;$excode
    return ret;
  }

%typemap(typecheck) PString = char *;

%typemap(throws, canthrow=1) PString
%{ SWIG_CSharpSetPendingException(SWIG_CSharpApplicationException, $1.ToString().c_str());
   return $null; %}

//////////////////
// const PString &
//////////////////
%typemap(ctype) const PString & "char *"
%typemap(imtype) const PString & "string"
%typemap(cstype) const PString & "string"


%typemap(csdirectorin) const PString & "$iminput"
%typemap(csdirectorout) const PString & "$cscall"

%typemap(in, canthrow=1) const PString &
%{ 
   if (!$input) {
    SWIG_CSharpSetPendingExceptionArgument(SWIG_CSharpArgumentNullException, "null string", 0);
    return $null;
   }
   $*1_ltype $1_str($input);
   $1 = &$1_str; 
   //$1 = new $*1_ltype($input);
   %}
%typemap(out) const PString & %{ $result = SWIG_csharp_string_callback($1->ToString().c_str()); %}

%typemap(csin) const PString & "$csinput"
%typemap(csout, excode=SWIGEXCODE) const PString & {
    string ret = $imcall;$excode
    return ret;
  }

%typemap(directorout, canthrow=1, warning=SWIGWARN_TYPEMAP_THREAD_UNSAFE_MSG) const PString &
%{ if (!$input) {
    SWIG_CSharpSetPendingExceptionArgument(SWIG_CSharpArgumentNullException, "null string", 0);
    return $null;
   }
   /* possible thread/reentrant code problem */
   static $*1_ltype $1_str;
   $1_str = $input;
   $result = &$1_str; %}

%typemap(directorin) const PString & %{ $input = SWIG_csharp_string_callback($1.ToString().c_str()); %}

%typemap(csvarin, excode=SWIGEXCODE2) const PString & %{
    set {
      $imcall;$excode
    } %}
%typemap(csvarout, excode=SWIGEXCODE2) const PString & %{
    get {
      string ret = $imcall;$excode
      return ret;
    } %}

%typemap(typecheck) const PString & = char *;

%typemap(throws, canthrow=1) const PString &
%{ SWIG_CSharpSetPendingException(SWIG_CSharpApplicationException, $1.ToString().c_str());
   return $null; %}

} // end namespace papillon

#endif


#ifdef SWIGJAVA
%include java.i
%apply const papillon::PString & {papillon::PString &};
#endif

%include "PapillonCommon.h"
%include "PapillonSDK.h"
%include "PRtti.h"
%include "PObject.h"



// lets make some nice strong boxed c/c++-types to use in Python 
%include "PBoxing.h"
%template(PBool) papillon::PBoxing<bool>;
%template(PInt8) papillon::PBoxing<papillon::int8>;
%template(PInt16) papillon::PBoxing<papillon::int16>;
%template(PInt32) papillon::PBoxing<papillon::int32>;
%template(PInt64) papillon::PBoxing<papillon::int64>;
%template(PUInt8) papillon::PBoxing<papillon::uint8>;
%template(PUInt16) papillon::PBoxing<papillon::uint16>;
%template(PUInt32) papillon::PBoxing<papillon::uint32>;
%template(PUInt64) papillon::PBoxing<papillon::uint64>;
%template(PFloat) papillon::PBoxing<float>;
%template(PDouble) papillon::PBoxing<double>;

%include "PPluginInstance.h"
%extend papillon::PPluginInstance
{
  
  papillon::PResult SetBoolean(const papillon::PString & key, bool v)
  {
    return self->Set(key, v);
  }

  bool GetBoolean(const papillon::PString & key)
  {
    bool v=false;
    self->Get(key, v);
    return v;
  }
  
  papillon::PResult SetInt(const papillon::PString & key, papillon::int32 v)
  {
    return self->Set(key, v);
  }

  papillon::int32 GetInt(const papillon::PString & key)
  {
    papillon::int32 v=-1;
    self->Get(key, v);
    return v;
  }

  papillon::PResult SetString(const papillon::PString & key, const papillon::PString & value)
  {
    return self->Set(key, value);
  }
  
  papillon::PString GetString(const papillon::PString & key)
  {
    papillon::PString v;
    self->Get(key, v);
    return v;
  }

  papillon::PResult SetDouble(const papillon::PString & key, double value)
  {
    return self->Set(key, value);
  }
 
  double GetDouble(const papillon::PString & key)
  {
    double v=-1.0;
    self->Get(key, v);
    return v;
  }
}

%include "PList.h"
%include "PMap.h"
%template(PStringMap) papillon::PMap<papillon::PString, papillon::PObject>;
%include "PByteStream.h"
%include "PByteArray.h"
%template(AsPtrDouble) papillon::PByteArray::AsPtr<double>;
%include "PColour3i.h"
%include "PComparer.h"
%include "PPoint2Df.h"
%include "PPoint2Di.h"
%include "PPoint2DfList.h"
%include "PPolygonf.h"
%include "PPolygoni.h"
%include "PProperties.h"
%include "PRectanglef.h"
%include "PRectanglei.h"
%include "PResult.h"
%include "PSizef.h"
%include "PSizei.h"
%include "PSocket.h"
%include "PDateTime.h"
%include "PDate.h"
%include "PDescriber.h"
%include "PObjectType.h"
%include "PGuid.h"
%include "PDescription.h"
%include "PDescriptor.h"
%include "PFeaturePoint.h"
%include "PFeatureRectangle.h"
#ifdef SWIGJAVA
%ignore papillon::PString::PString(const wchar_t*);
%ignore papillon::PString::PString(const std::string&);
%ignore papillon::PString::PString(const std::wstring&);
#endif
%include "PString.h"
%include "PStringList.h"
%include "PFeatureMap.h"
%include "PFrame.h"
%include "PImage.h"
%include "PTrack.h"
%include "PDetection.h"
%include "PDetectionList.h"
%include "PDetector.h"
%include "PExampleSet.h"
%include "PFrameToFrameTracker.h"
%include "PGPSLocation.h"
%include "PIdentifyResult.h"
%include "PIdentifyResults.h"
%include "PImageFilter.h"
%include "PInputVideoStream.h"
%include "PFaceMetaData.h"
%include "PMatchScore.h"
%include "PMath.h"
%include "PMemoryStream.h"
%template(WriteObjectDescription) papillon::PMemoryStream::WriteObject<papillon::PDescription>;
%template(ReadObjectDescription) papillon::PMemoryStream::ReadObject<papillon::PDescription>;

%include "POutputVideoStream.h"
%include "PTextFile.h"
%include "PTime.h"
%include "PTimer.h"
%include "PUri.h"
%include "PUtils.h"
%include "PVersion.h"
%include "PWatchlist.h"
%include "PWatchlistOptions.h"
%include "PLog.h"
%include "PEvent.h"
%include "PPath.h"
%include "PVideoTools.h"
%include "PAnalytics.h"

%include "PFileIO.h"
%template(WriteToFileWatchlist) papillon::PFileIO::WriteToFile<papillon::PWatchlist>;
%template(ReadFromFileWatchlist) papillon::PFileIO::ReadFromFile<papillon::PWatchlist>;
%include "PEntity.h"
%include "PSqlDatabase.h"
%include "PSqlQuery.h"
%include "PStore.h"
%include "PStoreIterator.h"
%include "PDatabaseStore.h"
//%include "POption.h"
%include "PEnrollment.h"
%include "PVerify.h"

// templates
%template(VectorInt) std::vector<int>;
%template(VectorDescription) std::vector<papillon::PDescription>;
%template(VectorDescriptor) std::vector<papillon::PDescriptor>;
%template(VectorImage) std::vector<papillon::PImage>;
%template(VectorPoint2Df) std::vector<papillon::PPoint2Df>;
%template(VectorPoint2Di) std::vector<papillon::PPoint2Di>;
%template(VectorEvent) std::vector<papillon::PEvent>;
%template(VectorGuid) std::vector<papillon::PGuid>;
%template(VectorByte) std::vector<unsigned char>;
%template(VectorString) std::vector<papillon::PString>;

%template(WriteToFile) papillon::PFileIO::WriteToFile<papillon::PDescription>;
%template(ReadFromFile) papillon::PFileIO::ReadFromFile<papillon::PDescription>;
