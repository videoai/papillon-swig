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
# This example shows how to use Face Detection module from Papillon SDK in python
#------------------------------------------------------------------------------

import Papillon as papillon

# Sample files folder
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")

# Never forget to initialise the papillon SDK and load the plugins
papillon.PapillonSDK.Initialise().OrDie()

# Set-up the console logger
papillon.PLog.OpenConsoleLogger()

# Set-up face detector
detector = papillon.PDetector()
papillon.PDetector_Create("FaceDetector2", papillon.PProperties(), detector)
detector.Set(papillon.PDetector.C_PARAM_BOOL_LOCALISER.c_str(), True)
detector.SetMinDetectionSize(80)

# Input a video stream from you-tube
inputStream = papillon.PInputVideoStream()
papillon.PInputVideoStream_Open(papillon.PPath_Join(SAMPLE_DIR, "face_log.avi"), inputStream).OrDie()

frame = papillon.PFrame()
while inputStream.GetFrame(frame).Ok() :
    detectionList = papillon.PDetectionList()
    detector.Detect(frame, detectionList)
    papillon.PUtils_DisplayDetectionList(frame, detectionList, "Papillon SDK - Face Detection")
