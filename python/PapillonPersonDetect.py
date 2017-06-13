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
# This example shows how to do persons detection using Papillon SDK in python
#------------------------------------------------------------------------------

import Papillon as papillon
import os

# Sample files folder
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")

papillon.PapillonSDK.Initialise().OrDie();

# Set-up: create a Motion detector
detector = papillon.PDetector()
papillon.PDetector_Create("PersonDetector", papillon.PProperties(), detector)

# Input video stream
inputStream = papillon.PInputVideoStream()
papillon.PInputVideoStream_Open(papillon.PPath_Join(SAMPLE_DIR, "glasgow.avi"), inputStream).OrDie()

frame = papillon.PFrame()
while inputStream.GetFrame(frame).Ok() :
    
    detectionList = papillon.PDetectionList()
    detector.Detect(frame, detectionList)
    image = frame.GetImage()
    papillon.PUtils.DrawDetectionList(image, detectionList)
    image.Display("Papillon SDK - Person Detection")
