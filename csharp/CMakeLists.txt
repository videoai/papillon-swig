INCLUDE(${SWIG_USE_FILE})

SET_SOURCE_FILES_PROPERTIES(../Papillon.i PROPERTIES CPLUSPLUS ON)

SET(CMAKE_SWIG_OUTDIR ${CMAKE_CURRENT_SOURCE_DIR}/src)

SWIG_ADD_MODULE(CSharpPapillonCore csharp ../Papillon.i)

SWIG_LINK_LIBRARIES(CSharpPapillonCore PapillonCore)

papillon_copy_dll(CSharpPapillonCore)

INSTALL(TARGETS CSharpPapillonCore DESTINATION bin)
INSTALL(FILES PapillonCore_CSharpExample/Example_UsingCSharp.csproj PapillonCore_CSharpExample/Program.cs PapillonCore_CSharpExample/app.config DESTINATION csharp)

