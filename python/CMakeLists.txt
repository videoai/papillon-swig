
INCLUDE(${SWIG_USE_FILE})

find_package(PythonLibs 2.7 REQUIRED)
papillon_print_variables_with_prefix("PYTHON_") 

include_directories(${PYTHON_INCLUDE_DIR})

SET(CMAKE_SWIG_OUTDIR ${CMAKE_CURRENT_SOURCE_DIR}/src)

SET(PYTHON_MODULE_NAME Papillon)

SET_SOURCE_FILES_PROPERTIES(Papillon.i PROPERTIES CPLUSPLUS ON)

if(POLICY CMP0026)
  cmake_policy(SET CMP0026 OLD)
endif()


SET(SWIG_MODULE_${PYTHON_MODULE_NAME}_EXTRA_DEPS ${PapillonCoreLibPath})

SWIG_ADD_MODULE(${PYTHON_MODULE_NAME} python Papillon.i)

SWIG_LINK_LIBRARIES(${PYTHON_MODULE_NAME} ${PAPILLON_LIBRARIES} ${PYTHON_LIBRARIES})

if(WIN32)
    INSTALL(TARGETS _${PYTHON_MODULE_NAME} DESTINATION bin)
    INSTALL(FILES src/Papillon.py DESTINATION bin)
else()
    INSTALL(TARGETS _${PYTHON_MODULE_NAME} DESTINATION lib)
    INSTALL(FILES src/Papillon.py DESTINATION lib)
endif()

INSTALL(FILES PapillonCoreExample.py PapillonCoreVideo.py PapillonFaceDetect.py PapillonMotionDetect.py PapillonPersonDetect.py DESTINATION examples/python)



#ADD_DEPENDENCIES(${PYTHON_MODULE_NAME} PapillonCore)

# copy across the Python dll to the binary directory
# Note, the library will have the extension .pyd and pre-fixes by an underscore
#papillon_copy_dll(_${PYTHON_MODULE_NAME})

# copy across the Python generated code to binary directory as well.
#papillon_postbuild_copy_file(_${PYTHON_MODULE_NAME} ${CMAKE_CURRENT_SOURCE_DIR}/src/${PYTHON_MODULE_NAME}.py $ENV{PAPILLON_BUILD_BIN}/${CMAKE_BUILD_TYPE})
