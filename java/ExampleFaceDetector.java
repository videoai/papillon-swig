//------------------------------------------------------------------------------
// Copyright (C) 2015-2016 Digital Barriers plc. All rights reserved.
// Contact: http://www.digitalbarriers.com/
// 
// This file is part of the Papillon SDK.
// 
// You can't use, modify or distribute any part of this file without
// the explicit written agreements of Digital Barriers plc.
//------------------------------------------------------------------------------
//
//------------------------------------------------------------------------------
// Description: 
// This example shows how to use Papillon SDK in Java for face-detection 
//------------------------------------------------------------------------------


public class ExampleFaceDetector {

    static {
        System.loadLibrary("PapillonCoreJava");
        PapillonSDK.Initialise();
    }

    public static void main(String[] args) {
        String TITLE = "Papillon SDK - Face Detection Example";
        String SAMPLE_DIR = PPath.Join(PUtils.GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples");
        boolean ENABLE_FACE_LOCALISER = true;
        
        
        // ************************************************************************
        // 1. Open Video Stream
        // ************************************************************************
        PInputVideoStream ivs = new PInputVideoStream();
        PInputVideoStream.Open(PPath.Join(SAMPLE_DIR, "face_log.avi"), ivs).OrDie(); // video file
        //PInputVideoStream.Open("https://youtu.be/Wi7k6IPYNj4?decode_with=vlc", ivs).OrDie(); break; // youtube stream (VLC plugin required)
        //PInputVideoStream.Open("device:0", ivs).OrDie();                                     break; // webcam
        //PInputVideoStream.Open(PPath.Join(SAMPLE_DIR, "face_log.avi"), ivs).OrDie();        break; // video file

        // ************************************************************************
        // 2. Create and configure Face Detector
        // ************************************************************************
        PDetector faceDetector = new PDetector();
        PProperties parameters = new PProperties();
        PDetector.Create("FaceDetector2", parameters, faceDetector).OrDie();
        faceDetector.EnableLocaliser(ENABLE_FACE_LOCALISER);
        faceDetector.SetMinDetectionSize(80);

        // ************************************************************************
        // 3. Apply Face Detector on each frame of the video stream
        // ************************************************************************
        PFrame frame = new PFrame();
        while (ivs.GetFrame(frame).Ok() && !PUtils.IsEscPressed())
        {
            PDetectionList listFaces = new PDetectionList();
            faceDetector.Detect(frame, listFaces);
            PUtils.DisplayDetectionList(frame, listFaces, TITLE);
        }

            


    }

}

