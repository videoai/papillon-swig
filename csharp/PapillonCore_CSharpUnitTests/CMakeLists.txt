
include_external_msproject(
    PapillonCore_CSharpUnitTests $ENV{PAPILLON_SOURCE}/SDK/Src/libcore/swig/csharp/PapillonCore_CSharpUnitTests/PapillonCore_CSharpUnitTests.csproj
    TYPE FAE04EC0-301F-11D3-BF4B-00C04F79EFBC)
    
ADD_DEPENDENCIES(PapillonCore_CSharpUnitTests PapillonCore_CSharp)