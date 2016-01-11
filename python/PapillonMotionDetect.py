import Papillon as papillon
import os
    
print "Running Papillon Motion Detector"
papillon.PapillonSDK.Initialise("Papillon Motion Detector Example").OrDie();

# Set-up 
detector = papillon.PDetector()
detectorOptions = papillon.PDetectorOptions()
detectorOptions.SetMinDetectionSize(papillon.PSizei(50, 50))
papillon.PDetector_Create("MotionDetector", "type=BACKGROUND_SUBSTRACTION", detector)


# Input video stream
path = os.getenv('PAPILLON_INSTALL_DIR') + "/Data/Samples/glasgow.avi"
inputStream = papillon.PInputVideoStream()
papillon.PInputVideoStream_Open(path, inputStream).OrDie()

# Output video stream
outputStream = papillon.POutputVideoStream()
papillon.POutputVideoStream_Open("output.mov?fps=10.0", outputStream).OrDie()

frame = papillon.PFrame()
while(inputStream.GetFrame(frame).Ok()) :
    
    detectionList = papillon.PDetectionList()
    detector.Detect(frame, detectorOptions, detectionList)
    image = frame.GetImage()
    papillon.PUtils.DrawDetectionList(image, detectionList)
    image.Display("Motion")

    # write to stream    
    outputStream.PutImage(image)
    
   
