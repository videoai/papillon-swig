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
// This example shows how to build a Papillon image from a CSharp byte array
//------------------------------------------------------------------------------
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
           PapillonSDK.Initialise();

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

           PImage image = new PImage();
           image.Set(buf, width, height, PImage.EPixelFormat.E_BGR8U);
           image.Display("Pink", 10000);

        }
    }
}
