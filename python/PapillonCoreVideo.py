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
# This example shows how to get and display a video stream using Papillon SDK in python
#------------------------------------------------------------------------------

import Papillon as papillon

# Sample files folder
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")

# Never forget to initialise the papillon SDK and load the plugins
papillon.PapillonSDK.Initialise().OrDie()
papillon.PLog.OpenConsoleLogger()    

def Play(ivs) :
    WAIT_TIME_MS = 20  # wait 20ms between each frame (i.e. display video stream at max 50 frames per second)
    TIME_OUT_MS = 5000 # wait 5 second maximum (optional parameter, you can simply write GetFrame(frame))
    frame = papillon.PFrame()
    
    # play input video stream until end-of-stream or ESCCAPE key pressed
    while (ivs.GetFrame(frame, TIME_OUT_MS).Ok()) :
         frame.Display("Papillon SDK - Play Video Stream", WAIT_TIME_MS);


# Use PInputVideoStream::Open(URL) to open a video stream:
# available video streams depends on Input Video Stream plugins installed on your system.
#
# Plugins exists for video files (e.g. H264), HTTP/HTTPS streams,
# RTSP streams, RTMP streams, TVI streams, webcams.

selectedDemo = 1
ivs = papillon.PInputVideoStream()

if selectedDemo == 0:
    papillon.PInputVideoStream_Open(papillon.PPath.Join(SAMPLE_DIR, "earth.avi?startFrame=100"), ivs).OrDie()
elif selectedDemo == 1:
    papillon.PInputVideoStream.Open("rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov?decode_with=vlc", ivs).OrDie()
elif selectedDemo ==2:
    papillon.PInputVideoStream.Open("https://www.youtube.com/watch?v=tXjVOFgNd5M", ivs).OrDie()
elif selectedDemo ==3:
    papillon.PInputVideoStream.Open("device:0", ivs).OrDie() # webcam

Play(ivs)
