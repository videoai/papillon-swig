require File.join(File.dirname(__FILE__), "..", "lib", "papillon", "facedetect")

INPUT = "/opt/Papillon/Data/Samples/face_log.mov"
OUTPUT = "output.avi?encode_with=opencv&fourcc=H264&fps=10.0"

Papillon.FaceDetect(INPUT, OUTPUT)