import Papillon as papillon
import os
    
print "Running Papillon Face Detector"

papillon.PapillonSDK.Initialise("Papillon Person Detector").OrDie();


# Set-up face detector
detector = papillon.PDetector()
detectorOptions = papillon.PDetectorOptions()
papillon.PDetector_Create("PersonDetector", "", detector)

# Input video stream
path = os.getenv('PAPILLON_INSTALL_DIR') + "/Data/Samples/glasgow.avi"
inputStream = papillon.PInputVideoStream()
papillon.PInputVideoStream_Open(path, inputStream).OrDie()

frame = papillon.PFrame()
while(inputStream.GetFrame(frame).Ok()) :
    
    detectionList = papillon.PDetectionList()
    detector.Detect(frame, detectorOptions, detectionList)
    papillon.PUtils.DisplayDetectionList(frame, detectionList, "Person Detector")
    
   
