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
# This example shows how to use Papillon SDK in python for basic image manipulation
#------------------------------------------------------------------------------

import Papillon as papillon
import os

# Sample files folder
SAMPLE_DIR = papillon.PPath_Join(papillon.PUtils_GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples")

# Initialise the papillon SDK and load the plugins
papillon.PapillonSDK.Initialise().OrDie()

# 1. load an image from disk (can be JPEG, TIF, BMP or PNG) and display it on screen
image = papillon.PImage()
image.Load(papillon.PPath_Join(SAMPLE_DIR, "sample.jpg")).OrDie()
image.Display("Papillon SDK - Sample image")

# 2. perform some basic manipulations
# create a new image by resizing the image loaded before
image2 = papillon.PImage()
image.Resize(image2, image.ScaleSize(2.0), papillon.PImage.E_INTERPOLATION_CUBIC)
# extract a sub-image
image2.ExtractSubImage(image2, 50, 50, 700, 500)
# draw a rectangle on top of the image
image2.DrawRectangle(papillon.PRectanglei(5, 5, 690, 490), papillon.PColour3i.Black(), 2)
# convert the image to grayscale
image2.Convert(image2, papillon.PImage.E_GREY8U)
# display the new image in another window
image2.Display("Papillon SDK - Sample image 2")

# 3. save image to JPG format with a quality set to 90%
# (quality is an optional parameter; set to 95 by default)
image.Save("img1.jpg", 90)
image2.Save("img2.png")

 # 4. apply ENHANCE BRIGHTNESS image filter
brightnessFilter  = papillon.PImageFilter() 
papillon.PImageFilter_Create("EnhanceBrightness", papillon.PProperties(), brightnessFilter).OrDie();
brightnessFilter.Set("scale", 2.0)
brightnessFilter.Set("delta", 30)
brightImage = papillon.PImage()
brightnessFilter.Apply(image, brightImage)
brightImage.Display("Papillon SDK - Brightness Enhanced", papillon.WAIT_FOR_RETURN)
