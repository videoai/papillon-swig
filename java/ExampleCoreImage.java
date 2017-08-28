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
// This example shows how to use Papillon SDK in Java for basic image manipulation
//------------------------------------------------------------------------------


public class ExampleCoreImage {

    static {
        System.loadLibrary("PapillonCoreJava");
        PapillonSDK.Initialise();
    }

    public static void main(String[] args) {
        String SAMPLE_DIR = PPath.Join(PUtils.GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples");
       
        
        // 1. load an image from disk (can be JPEG, TIF, BMP or PNG) and display it on screen
        PImage image = new PImage();
        image.Load(PPath.Join(SAMPLE_DIR, "sample.jpg")).OrDie();
        image.DisplayScaled("Papillon SDK - Original");
        // 2. perform some basic manipulations
        PImage image2 = new PImage();
        image.Resize(image2, 2.0f, PImage.EInterpolation.E_INTERPOLATION_CUBIC);                 // create a new image by resizing the image loaded before
        image2.ExtractSubImage(image2, 50, 50, 700, 500);                          // extract a sub-image
        image2.DrawRectangle(new PRectanglei(5, 5, 690, 490), PColour3i.Black(), 2);  // draw a rectangle on top of the image
        image2.Convert(image2, PImage.EPixelFormat.E_GREY8U);                                  // convert image to grayscale
        image2.Display("Papillon SDK - Some basic manipulations");                 // display the new image in another window
        PImage rotatedImage = new PImage();
        image.Rotate(rotatedImage, 0);
        rotatedImage.Display("Rotated", 1500);
        image.Rotate(rotatedImage, 90);
        rotatedImage.Display("Rotated", 1500);
        image.Rotate(rotatedImage, 270);
        rotatedImage.Display("Rotated", 1500);
        image.Rotate(rotatedImage, -90);
        rotatedImage.Display("Rotated", 1500);
        // 3. save image to JPG format with a quality set to 90%
        image.Save("img1.jpg", 90);                                                                         // quality is an optional parameter; set to 95 by default
        image2.Save("img2.png");
        // 4. apply ENHANCE BRIGHTNESS image filter if the plugin is available)
        PImageFilter brightnessFilter = new PImageFilter();
        PProperties params = new PProperties();
        if (PImageFilter.Create("EnhanceBrightness", params, brightnessFilter).Ok())                          // create image filter from plugin
        {
            brightnessFilter.Set("scale", new PDouble(1.5));
            brightnessFilter.Set("delta", new PDouble(20));

            PImage brightImage = new PImage();
            brightnessFilter.Apply(image, brightImage);
            brightImage.Display("Papillon SDK - Enhance brightness");

            // swap red and blue channels
            PImage brightImageSwapped = new PImage();
            brightImage.SwapRGB(brightImageSwapped);
            brightImageSwapped.Display("Papillon SDK - Enhance brightness (rgb swapped)");   
        }

        // 5. apply LACE image filter (if the plugin is available)
        PImageFilter laceFilter = new PImageFilter();
        PProperties laceFilterParameters = new PProperties();
        laceFilterParameters.Set("strength", new PDouble(0.5));
        if (PImageFilter.Create("LACE", laceFilterParameters, laceFilter).Ok())                                             // create image filter from plugin
        {
            PImage lacedImage = new PImage();       
            laceFilter.Apply(image, lacedImage);
            lacedImage.Display("Papillon SDK - LACE (strength 0.5)");
        }
        // 6. apply HISTOGRAM EQUALISATION image filter (if the plugin is available)
        PImageFilter histogramEqualisationFilter = new PImageFilter();
        if (PImageFilter.Create("HistogramEqualisation", new PProperties(), histogramEqualisationFilter).Ok())           // create image filter from plugin
        {
            PImage histogramEqualisedImage = new PImage();
            histogramEqualisationFilter.Apply(image, histogramEqualisedImage);
            histogramEqualisedImage.Display("Papillon SDK - Histogram Equalised", 1000);
        }

    }

}

