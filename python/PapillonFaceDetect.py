import Papillon as papillon

# Never forget to initialise the papillon SDK and load the plugins
papillon.PapillonSDK.Initialise('A Python Example').OrDie()

# Set-up the console logger
papillon.PLog.OpenConsoleLogger()

# We have some files to use here    
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")

# Set-up face detector
detector = papillon.PDetector()
detectorOptions = papillon.PDetectorOptions()
detectorOptions.SetIntParameter("LOCALISER", 0) # Set to 1 if you want localisation
detectorOptions.SetMinDetectionSize(50)
detectorOptions.SetThreshold(1.0)
papillon.PDetector_Create("FaceDetector", "", detector)


# Input a video stream from you-tube
inputStream = papillon.PInputVideoStream()
papillon.PInputVideoStream_Open("https://youtu.be/Wi7k6IPYNj4", inputStream).OrDie()
frame = papillon.PFrame()

while(inputStream.GetFrame(frame).Ok()) :
    detectionList = papillon.PDetectionList()
    detector.Detect(frame, detectorOptions, detectionList)
    papillon.PUtils_DisplayDetectionList(frame, detectionList, "Face Detection", 0.5)
    
  
    
    
    
   
