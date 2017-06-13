#------------------------------------------------------------------------------
# Copyright (C) 2015-2016 Digital Barriers plc. All rights reserved.
# Contact: http://www.digitalbarriers.com/
# 
# This file is part of the Papillon SDK.
# 
# You can't use, modify or distribute any part of this file without
# the explicit written agreements of Digital Barriers plc.
#------------------------------------------------------------------------------

#------------------------------------------------------------------------------
# Description: 
# This example shows how to do basic motion detection using Papillon SDK in python.
# The video stream with overlaid motion detection is recorded to an output video file.
#------------------------------------------------------------------------------

import Papillon as papillon
import os

# Sample files folder
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")

papillon.PapillonSDK.Initialise().OrDie();

# Set-up: create a Motion detector
detector = papillon.PDetector()
papillon.PDetector_Create("MotionDetector", papillon.PProperties.CreateFromKeyValueString("type=BACKGROUND_SUBSTRACTION"), detector)
detector.SetMinDetectionSize(papillon.PSizei(50, 50))

# Input video stream
inputStream = papillon.PInputVideoStream()
papillon.PInputVideoStream_Open(papillon.PPath_Join(SAMPLE_DIR, "glasgow.avi"), inputStream).OrDie()

# Output video stream
outputStream = papillon.POutputVideoStream()
papillon.POutputVideoStream_Open("output.avi?fps=10.0", outputStream).OrDie()

frame = papillon.PFrame()
while inputStream.GetFrame(frame).Ok():
    
    detectionList = papillon.PDetectionList()
    detector.Detect(frame, detectionList)
    image = frame.GetImage()
    papillon.PUtils.DrawDetectionList(image, detectionList)
    image.Display("Papillon SDK - Basic Motion Detection")

    # write to stream    
    outputStream.PutFrame(papillon.PFrame(image))
