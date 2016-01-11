using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace example
{
    class Program 
    {
        static void Main(string[] args) {

           // **********************
           // intialise Papillon SDK
           // **********************
           PLog.OpenConsoleLogger();
           PapillonSDK.Initialise("PapillonCSharpDemo");
           string SAMPLE_DIR = PPath.Join(PUtils.GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples");

           // *********************************************************************
           // load an image from disk (can be JPEG, TIF, BMP or PNG) and display it
           // *********************************************************************
           PImage image = new PImage();
           image.Load(PPath.Join(SAMPLE_DIR, "sample.jpg")).OrDie();
           image.Display("MySampleImage");

           // **********************************************************
           // set an image from a pixel buffer (a byte[]) and display it
           //***********************************************************
           int width = 600;
           int height = 400;
           int depth = 3;

           var buf = new byte[width * height * depth];

           for (int i = 0; i < buf.Length; i+=depth) {
               buf[i] = 127;
               buf[i + 1] = 0;
               buf[i + 2] = 255;
           }

           PImage image2 = new PImage();
           image2.Set(buf, width, height, PImage.EPixelFormat.E_BGR8U);
           image2.Display("Pink");

           // **********************************************************
           // open a video stream from local webcam, then
           // 1. display the video stream
           // 2. write it on the disk (AVI file)
           // 3. stabilise the video stream (if the "stabilisation" plugin is available)
           // 4. perform face detection on the video stream
           //***********************************************************
           PInputVideoStream inputStream = new PInputVideoStream();
           PInputVideoStream.Open("device:0", inputStream).OrDie();

           POutputVideoStream outputStream = new POutputVideoStream();
           POutputVideoStream.Open("webcam.avi?fps=20.0", outputStream).OrDie();

           bool isStabilisationEnabled = false;
           PImage stabilisedImage = new PImage();
           PImageFilterOptions stabilisationOptions = new PImageFilterOptions();
           PImageFilter stabilisationFilter = new PImageFilter();

           if (PImageFilter.Create("Stabilisation", "", stabilisationFilter).Ok()) {
               stabilisationOptions.SetDoubleParameter("motion", 0.5);
               stabilisationOptions.SetIntParameter("panning", 0);
               isStabilisationEnabled = true;
           }

           PFrame frame = new PFrame();

           PDetector faceDetector = new PDetector();
           PDetector.Create("FaceDetector", "", faceDetector).OrDie();

           PDetectorOptions detectorOptions = new PDetectorOptions();
           detectorOptions.SetIntParameter("LOCALISER", 0); // no localiser
           detectorOptions.SetMinDetectionSize(60);

           PDetectionList detectionList = new PDetectionList();

           while (inputStream.GetFrame(frame).Ok()) {
               frame.Display("Web-cam image", 50);
               outputStream.PutImage(frame.GetImage());

               if (isStabilisationEnabled) {
                   stabilisationFilter.Apply(frame.GetImage(), stabilisationOptions, stabilisedImage);
                   stabilisedImage.Display("Stabilised stream");
               }

               faceDetector.Detect(frame, detectorOptions, detectionList);
               PUtils.DisplayDetectionList(frame, detectionList, "Face Detector");
           }
        }
    }
}
