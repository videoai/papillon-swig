INCLUDE(${SWIG_USE_FILE})

find_package(JNI REQUIRED)
find_package(Java REQUIRED)

include(UseJava)

INCLUDE_DIRECTORIES(${JNI_INCLUDE_DIRS})


SET(JAVA_MODULE_NAME PapillonCoreJava)

SET_SOURCE_FILES_PROPERTIES(../Papillon.i PROPERTIES CPLUSPLUS ON)

# Very important on Linux otherwise pint64 gets defined incorrectly
if(UNIX)
    SET(CMAKE_SWIG_FLAGS -DSWIGWORDSIZE64)
endif()

# Configure the java package
SET(JAVA_PACKAGE_PATH "")

if(JAVA_PACKAGE)
    MESSAGE( STATUS "Custom JAVA_PACKAGE:" ${JAVA_PACKAGE} )
else()
    # use the default package
    SET(JAVA_PACKAGE "net.videoai.papillon.core")
    MESSAGE( STATUS "Use default JAVA_PACKAGE:" ${JAVA_PACKAGE} )
endif()

SET(CMAKE_SWIG_FLAGS ${CMAKE_SWIG_FLAGS} -package ${JAVA_PACKAGE})
string(REPLACE "\." "/" JAVA_PACKAGE_PATH "${JAVA_PACKAGE}")

#SET(CMAKE_SWIG_OUTDIR ${CMAKE_CURRENT_SOURCE_DIR}/PapillonCoreJava/${JAVA_PACKAGE_PATH})
SET(CMAKE_SWIG_OUTDIR ${CMAKE_CURRENT_BINARY_DIR}/${JAVA_PACKAGE_PATH})

if(POLICY CMP0026)
  cmake_policy(SET CMP0026 OLD)
endif()


SET(SWIG_MODULE_${JAVA_MODULE_NAME}_EXTRA_DEPS ${PapillonCoreLibPath})

SWIG_ADD_MODULE(${JAVA_MODULE_NAME} java ../Papillon.i)

SWIG_LINK_LIBRARIES(${JAVA_MODULE_NAME} ${PAPILLON_LIBRARIES})


# Copy dynamic library to current build folder
add_custom_command(
    TARGET ${JAVA_MODULE_NAME}
    POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy_if_different $<TARGET_FILE:${JAVA_MODULE_NAME}> ${CMAKE_CURRENT_BINARY_DIR}
    )

# Build the jar
FILE(MAKE_DIRECTORY "${CMAKE_CURRENT_BINARY_DIR}/classes")

ADD_CUSTOM_COMMAND(TARGET ${JAVA_MODULE_NAME} POST_BUILD
    COMMAND "${Java_JAVAC_EXECUTABLE}" -d classes ${CMAKE_SWIG_OUTDIR}/*.java
    COMMAND "${Java_JAR_EXECUTABLE}" -cfM PapillonCoreJava.jar -C classes .
)


if(WIN32)
    INSTALL(TARGETS ${JAVA_MODULE_NAME} DESTINATION bin)
    INSTALL(FILES ${CMAKE_CURRENT_BINARY_DIR}/PapillonCoreJava.jar DESTINATION bin)
else()
    INSTALL(TARGETS ${JAVA_MODULE_NAME} DESTINATION lib)
    INSTALL(FILES ${CMAKE_CURRENT_BINARY_DIR}/PapillonCoreJava.jar DESTINATION lib)
endif()

INSTALL(FILES ExampleCoreImage.java 
            ExampleFaceDetector.java 
            ExampleFaceRecognition.java 
            DESTINATION examples/java)


