require 'papillon'

#print Papillon.constants.select {|c| Class === Papillon.const_get(c)}

Papillon::PapillonSDK::Initialise(Papillon::PString.new("A Ruby Example")).OrDie()

Papillon::PLog::OpenConsoleLogger()

# We have some files to use here    
SAMPLE_DIR = Papillon::PPath::Join(Papillon::PUtils::GetEnv(Papillon::PString.new("PAPILLON_INSTALL_DIR")), Papillon::PString.new("Data"), Papillon::PString.new("Samples"))

# Set-up face detector
detector = Papillon::PDetector.new
detectorOptions = Papillon::PDetectorOptions.new
detectorOptions.SetIntParameter(Papillon::PString.new("LOCALISER"), 0) # Set to 1 if you want localisation
detectorOptions.SetMinDetectionSize(50)
detectorOptions.SetThreshold(1.0)
Papillon::PDetector::Create(Papillon::PString.new("FaceDetector"), Papillon::PString.new(""), detector)


# Input a video stream from you-tube
inputStream = Papillon::PInputVideoStream.new
Papillon::PInputVideoStream::Open(Papillon::PString.new("/opt/Papillon/Data/Samples/face_log.mov"), inputStream).OrDie()
frame =Papillon::PFrame.new

detectionList = Papillon::PDetectionList.new
detector::Detect(frame, detectorOptions, detectionList)
#Papillon::PUtils::DisplayDetectionList(frame, detectionList, "Face Detection", 0.)
