%module Papillon


%include <std_string.i>
%include <std_vector.i>
%include <std_wstring.i>



%{
#include <PapillonCore.h>
%}




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

%include "../PapillonCommon.i"
