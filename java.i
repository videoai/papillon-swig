
namespace papillon {

class PString;

// PString
%typemap(jni) PString "jstring"
%typemap(jtype) PString "String"
%typemap(jstype) PString "String"
%typemap(javadirectorin) PString "$jniinput"
%typemap(javadirectorout) PString "$javacall"

%typemap(in) PString 
%{ if(!$input) {
     SWIG_JavaThrowException(jenv, SWIG_JavaNullPointerException, "null PString");
     return $null;
    } 
    const char *$1_pstr = (const char *)jenv->GetStringUTFChars($input, 0); 
    if (!$1_pstr) return $null;
    $1 =  papillon::PString($1_pstr);
    jenv->ReleaseStringUTFChars($input, $1_pstr); %}

%typemap(directorout) PString 
%{ if(!$input) {
     SWIG_JavaThrowException(jenv, SWIG_JavaNullPointerException, "null PString");
     return $null;
   } 
   const char *$1_pstr = (const char *)jenv->GetStringUTFChars($input, 0); 
   if (!$1_pstr) return $null;
   $result =  papillon::PString($1_pstr);
   jenv->ReleaseStringUTFChars($input, $1_pstr); %}

%typemap(directorin,descriptor="Ljava/lang/String;") PString 
%{ $input = jenv->NewStringUTF($1.c_str()); %}

%typemap(out) PString 
%{ $result = jenv->NewStringUTF($1.c_str()); %}

%typemap(javain) PString "$javainput"

%typemap(javaout) PString {
    return $jnicall;
  }

%typemap(typecheck) PString = char *;

%typemap(throws) PString
%{ SWIG_JavaThrowException(jenv, SWIG_JavaRuntimeException, $1.c_str());
   return $null; %}


// PString &

%typemap(jni) PString & "jstring"
%typemap(jtype) PString & "String"
%typemap(jstype) PString & "String"
%typemap(javadirectorin) PString & "$jniinput"
%typemap(javadirectorout) PString & "$javacall"

%typemap(in) PString &
%{ if(!$input) {
     SWIG_JavaThrowException(jenv, SWIG_JavaNullPointerException, "null PString");
     return $null;
   }
   const char *$1_pstr = (const char *)jenv->GetStringUTFChars($input, 0); 
   if (!$1_pstr) return $null;
   papillon::PString $1_str($1_pstr);
   $1 = &$1_str;
   jenv->ReleaseStringUTFChars($input, $1_pstr); %}

%typemap(directorout,warning=SWIGWARN_TYPEMAP_THREAD_UNSAFE_MSG) PString &
%{ if(!$input) {
     SWIG_JavaThrowException(jenv, SWIG_JavaNullPointerException, "null PString");
     return $null;
   }
   const char *$1_pstr = (const char *)jenv->GetStringUTFChars($input, 0); 
   if (!$1_pstr) return $null;
   /* possible thread/reentrant code problem */
   static Papillon::PString $1_str;
   $1_str = $1_pstr;
   $result = &$1_str;
   jenv->ReleaseStringUTFChars($input, $1_pstr); %}

%typemap(directorin,descriptor="Ljava/lang/String;") PString &
%{ $input = jenv->NewStringUTF($1.c_str()); %}

%typemap(out) const PString & 
%{ $result = jenv->NewStringUTF($1->cstr()); %}

%typemap(javain) PString & "$javainput"

%typemap(javaout) PString & {
    return $jnicall;
  }

%typemap(typecheck) PString & = char *;

%typemap(throws) PString &
%{ SWIG_JavaThrowException(jenv, SWIG_JavaRuntimeException, $1.c_str());
   return $null; %}


// const PString &

%typemap(jni) const PString & "jstring"
%typemap(jtype) const PString & "String"
%typemap(jstype) const PString & "String"
%typemap(javadirectorin) const PString & "$jniinput"
%typemap(javadirectorout) const PString & "$javacall"

%typemap(in) const PString &
%{ if(!$input) {
     SWIG_JavaThrowException(jenv, SWIG_JavaNullPointerException, "null PString");
     return $null;
   }
   const char *$1_pstr = (const char *)jenv->GetStringUTFChars($input, 0); 
   if (!$1_pstr) return $null;
   papillon::PString $1_str($1_pstr);
   $1 = &$1_str;
   jenv->ReleaseStringUTFChars($input, $1_pstr); %}

%typemap(directorout,warning=SWIGWARN_TYPEMAP_THREAD_UNSAFE_MSG) const PString &
%{ if(!$input) {
     SWIG_JavaThrowException(jenv, SWIG_JavaNullPointerException, "null PString");
     return $null;
   }
   const char *$1_pstr = (const char *)jenv->GetStringUTFChars($input, 0); 
   if (!$1_pstr) return $null;
   /* possible thread/reentrant code problem */
   static papillon::PString $1_str;
   $1_str = $1_pstr;
   $result = &$1_str;
   jenv->ReleaseStringUTFChars($input, $1_pstr); %}

%typemap(directorin,descriptor="Ljava/lang/String;") const PString &
%{ $input = jenv->NewStringUTF($1.c_str()); %}

%typemap(out) const PString & 
%{ $result = jenv->NewStringUTF($1->c_str()); %}

%typemap(javain) const PString & "$javainput"

%typemap(javaout) const PString & {
    return $jnicall;
  }

%typemap(typecheck) const PString & = char *;

%typemap(throws) const PString &
%{ SWIG_JavaThrowException(jenv, SWIG_JavaRuntimeException, $1.c_str());
   return $null; %}


} // end namespace papillon
