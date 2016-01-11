%module PapillonCoreJava

#%include <windows.i>
%include <std_string.i>
%include <std_wstring.i>

%{
#include <PapillonCore.h>
%}

#define PAPILLON_API_CORE
#define FORCEINLINE


%include "PapillonDataTypes.h"
%include "PapillonSDK.h"
%include "PInputStream.h"
%include "POutputStream.h"
%include "PSerialisationInterface.h"
%include "PByteArray.h"
%include "PByteArrayInputStream.h"
%include "PByteArrayOutputStream.h"
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
%include "PStatus.h"
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
%include "PMatchScore.h"
%include "PMath.h"
%include "POutputVideoStream.h"
%include "PStdInputStream.h"
%include "PStdOutputStream.h"
%include "PTextFile.h"
%include "PTime.h"
%include "PTimer.h"
%include "PUri.h"
%include "PUtils.h"
%include "PVersion.h"
%include "PWatchlist.h"

%include "PLog.h"



