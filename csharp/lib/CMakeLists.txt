
include_external_msproject(
    PapillonCore_CSharp 
	${CMAKE_CURRENT_BINARY_DIR}/PapillonCore_CSharp.csproj
    TYPE FAE04EC0-301F-11D3-BF4B-00C04F79EFBC)
    
ADD_DEPENDENCIES(PapillonCore_CSharp PapillonCoreCSharp)

configure_file(PapillonCore_CSharp.csproj.in 
		       ${CMAKE_CURRENT_BINARY_DIR}/PapillonCore_CSharp.csproj)
