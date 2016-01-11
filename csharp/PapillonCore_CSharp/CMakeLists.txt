



include_external_msproject(
    PapillonCore_CSharp $ENV{PAPILLON_SOURCE}/SDK/Src/libcore/swig/csharp/PapillonCore_CSharp/PapillonCore_CSharp.csproj
    TYPE FAE04EC0-301F-11D3-BF4B-00C04F79EFBC)
    
ADD_DEPENDENCIES(PapillonCore_CSharp CSharpPapillonCore)

# Unfortunately a bit of a hack. Not sure what to quote as target as project external to cmake
INSTALL(FILES $ENV{PAPILLON_BUILD_BIN}/Release/PapillonCore_CSharp.dll DESTINATION bin)