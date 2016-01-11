#ifdef SWIGRUBY
%module papillon
#else
%module Papillon
#endif

%include <std_string.i>
%include <std_vector.i>


#ifndef SWIGGO
%include <std_wstring.i>
#endif

%{
#include <PapillonCore.h>
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

%include "PapillonDataTypes.h"
%include "PapillonSDK.h"
%include "PByteStream.h"
%include "PSerialisationInterface.h"
%include "PByteArray.h"
%include "PClassId.h"
%include "PColour3f.h"
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
%include "PString.h"
%include "PStringList.h"
%include "PFeatureMap.h"
%include "PFrame.h"
%include "PImage.h"
%include "PTrack.h"
%include "PDetection.h"
%include "PDetectionList.h"
%include "PDetector.h"
%include "PDetectorOptions.h"
%include "PExampleSet.h"
%include "PFrameToFrameTracker.h"
%include "PGPSLocation.h"
%include "PIdentifyResult.h"
%include "PIdentifyResults.h"
%include "PImageFilter.h"
%include "PImageFilterOptions.h"
%include "PInputVideoStream.h"
%include "PMap.h"


//%include "../../app/SZeOnWintel/supervisor/PSupervisor.h"

%extend papillon::PInputVideoStream
{
  papillon::int32 GetInt(const papillon::PString & key)
  {
    papillon::int32 v=-1;
    self->Get(key, v);
    return v;
  }
  
  papillon::PResult SetInt(const papillon::PString & key, papillon::int32 v)
  {
    return self->Set(key, v);
  }
  
  papillon::int32 GetDouble(const papillon::PString & key)
  {
    double v=-1.0;
    self->Get(key, v);
    return v;
  }
    
}
%include "PMatchScore.h"
%include "PMath.h"
%include "PMemoryStream.h"
%template(WriteObjectDescription) papillon::PMemoryStream::WriteObject<papillon::PDescription>;
%template(ReadObjectDescription) papillon::PMemoryStream::ReadObject<papillon::PDescription>;

%include "POutputVideoStream.h"
//%include "PStdStream.h"
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
%include "PList.h"
%include "PFileIO.h"

// The interfaces, not sure we need these though
// %include "PAnalyticsInterface.h"
// %include "PDescriberInterface.h"
// %include "PDetectorInterface.h"
// %include "PFrameToFrameTrackerInterface.h"
// %include "PImageFilterInterface.h"
// %include "POutputStream.h"

// Lets include some templates for PList
%template(PListInt) papillon::PList<int>;
%template(PListEvent) papillon::PList<papillon::PEvent>;
%template(PListGuid) papillon::PList<papillon::PGuid>;
%template(PListDescription) papillon::PList<papillon::PDescription>;
%template(PListDescriptor) papillon::PList<papillon::PDescriptor>;
%template(PListImage) papillon::PList<papillon::PImage>;
%template(PListString) papillon::PList<papillon::PString>;

%template(VectorInt) std::vector<int>;
%template(VectorDescription) std::vector<papillon::PDescription>;
%template(VectorDescriptor) std::vector<papillon::PDescriptor>;
%template(VectorImage) std::vector<papillon::PImage>;
%template(VectorPoint2Df) std::vector<papillon::PPoint2Df>;
%template(VectorPoint2Di) std::vector<papillon::PPoint2Di>;
//%template(VectorUChar) std::vector<unsigned char>;
%template(VectorEvent) std::vector<papillon::PEvent>;
%template(VectorGuid) std::vector<papillon::PGuid>;
%template(VectorByte) std::vector<unsigned char>;
%template(VectorString) std::vector<papillon::PString>;


%template(PMapStringFeaturePoint) papillon::PMap<papillon::PString, papillon::PFeaturePoint>;
%template(PMapStringFeatureRectangle) papillon::PMap<papillon::PString, papillon::PFeatureRectangle>;
%template(PMapIteratorStringFeaturePoint) papillon::PMapIterator<papillon::PString, papillon::PFeaturePoint>;
%template(PMapIteratorStringFeatureRectangle) papillon::PMapIterator<papillon::PString, papillon::PFeatureRectangle>;

//%template(VectorPoint2Df> std::vector<papillon::PPoint2Df>;
//%template(VectorPoint2Di> std::vector<papillon::PPoint2Di>;

// Lets include some template definitions for PProperties
%template(SetInt) papillon::PProperties::Set<papillon::int32>;
%template(SetInt64) papillon::PProperties::Set<papillon::int64>;
%template(SetString) papillon::PProperties::Set<papillon::PString>;
%template(SetDouble) papillon::PProperties::Set<double>;
%template(SetBoolean) papillon::PProperties::Set<bool>;
%template(SetImage) papillon::PProperties::Set<papillon::PImage>;
%template(SetDetection) papillon::PProperties::Set<papillon::PDetection>;
%template(SetDescription) papillon::PProperties::Set<papillon::PDescription>;

%template(GetInt) papillon::PProperties::Get<papillon::int32>;
%template(GetInt64) papillon::PProperties::Get<papillon::int64>;
%template(GetString) papillon::PProperties::Get<papillon::PString>;
%template(GetDouble) papillon::PProperties::Get<double>;
%template(GetBoolean) papillon::PProperties::Get<bool>;
%template(GetImage) papillon::PProperties::Get<papillon::PImage>;
%template(GetDetection) papillon::PProperties::Get<papillon::PDetection>;
%template(GetDescription) papillon::PProperties::Get<papillon::PDescription>;
%template(GetEvent) papillon::PProperties::Get<papillon::PList<papillon::PEvent> >;
%template(GetGuid) papillon::PProperties::Get<papillon::PList<papillon::PGuid> >;


%extend papillon::PProperties {
  papillon::int32 GetInt(const papillon::PString & key)
  {
    papillon::int32 v=-1;
    self->Get(key, v);
    return v;
  }

}
 
%extend papillon::PProperties {
   
   papillon::int64 GetInt64(const papillon::PString & key)
   {
     papillon::int64 v=-1;
     self->Get(key, v);
     return v;
   }    
}

 
%extend papillon::PProperties {
   
   double GetDouble(const papillon::PString & key)
   {
     double v=-1.0;
     self->Get(key, v);
     return v;
   }    
}

%extend papillon::PProperties {
   
   papillon::PString GetString(const papillon::PString & key)
   {
     papillon::PString v;
     self->Get(key, v);
     return v;
   }    
}

// Some templates for reading and writing objects from file
%template(WriteToFile) papillon::PFileIO::WriteToFile<papillon::PDescription>;
%template(ReadFromFile) papillon::PFileIO::ReadFromFile<papillon::PDescription>;

