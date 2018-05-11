
foreach (EXAMPLE 	ExampleCoreImage 
					ExampleFaceDetector 
					ExampleFaceRecognition 
					ExampleImageFromByteArray
		)

include_external_msproject(
    ${EXAMPLE}
	${CMAKE_CURRENT_SOURCE_DIR}/${EXAMPLE}.csproj
    TYPE FAE04EC0-301F-11D3-BF4B-00C04F79EFBC
)
ADD_DEPENDENCIES(${EXAMPLE} PapillonCore_CSharp)

configure_file(PapillonCore_CSharpExample.csproj.in 
			${CMAKE_CURRENT_SOURCE_DIR}/${EXAMPLE}.csproj
)


endforeach(EXAMPLE)