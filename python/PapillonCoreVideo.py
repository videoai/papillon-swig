import Papillon as papillon
    
# Never forget to initialise the papillon SDK and load the plugins
papillon.PapillonSDK.Initialise('A Python Example').OrDie()
papillon.PLog.OpenConsoleLogger()    
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")


def Play(ivs) :
    WAIT_TIME_MS = 20 # wait 20ms between each frame (i.e. display video stream at max 50 frames per second)
    TIME_OUT_MS = 5000 # wait 5 second maximum (optional parameter, you can simply write GetFrame(frame))
    frame = papillon.PFrame()
    
    while (ivs.GetFrame(frame, TIME_OUT_MS).Ok()) :
         # play input video stream until end-of-stream or ESCCAPE key pressed
         frame.Display("Papillon Example - Play Video Stream", WAIT_TIME_MS);


# Use PInputVideoStream::Open(URL) to open a video stream:
# available video streams depends on Input Video Stream plugins installed on your system.
#
# Plugins exists for video files (e.g. H264), HTTP/HTTPS streams,
# RTSP streams, RTMP streams, TVI streams, webcams.

selectedDemo = 2
ivs = papillon.PInputVideoStream()

if selectedDemo == 0: 
    papillon.PInputVideoStream_Open(papillon.PPath_Join(SAMPLE_DIR, "earth.mp4?startFrame=100"), ivs).OrDie()
elif selectedDemo == 1:
    papillon.PInputVideoStream_Open("rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov", ivs).OrDie()
elif selectedDemo ==2:
    papillon.PInputVideoStream_Open("https://www.youtube.com/watch?v=tXjVOFgNd5M", ivs).OrDie()
elif selectedDemo ==3:
    papillon.PInputVideoStream_Open("device:0", ivs).OrDie()

Play(ivs)




