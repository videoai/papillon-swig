require File.join(File.dirname(__FILE__), "..", "lib", "papillon", "facedetect")

INPUT = "/opt/Papillon/Data/Samples/face_log.mov"
OUTPUT = "output.avi"

Papillon.FaceDetect(INPUT, OUTPUT)