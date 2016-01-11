using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PapillonTests
{
    [TestClass]
    public class ImageTests
    {

        [TestInitialize]
        public void Initialize()
        {
            System.Diagnostics.Debug.WriteLine("Papillon Initialise...");
            PLog.OpenConsoleLogger();
            PapillonSDK.Initialise("UnitTests");
        }


        [TestMethod]
        public void TestImage()
        {
            string SAMPLE_DIR = PPath.Join(PUtils.GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples");
            PImage image = new PImage();
            Assert.IsTrue(image.Load(PPath.Join(SAMPLE_DIR, "sample.jpg")).Ok());
            Assert.IsFalse(image.Load(PPath.Join(SAMPLE_DIR, "sample2.jpg")).Ok());
            PImage image2 = new PImage();
            Assert.IsTrue(image2.Load(PPath.Join(SAMPLE_DIR, "sample.jpg")).Ok());
            Assert.IsTrue(image.IsSame(image2));
        }


        [TestMethod]
        public void TestImageFromUserData()
        {  
           int width = 600;
           int height = 400;
           int depth = 3;
           var buf = new byte[width * height * depth];
           PColour3i colour = PColour3i.C_PINK;
           for (int i = 0; i < buf.Length; i+=depth)
           {
               buf[i] = (byte)colour.b;
               buf[i + 1] = (byte)colour.g;
               buf[i + 2] = (byte)colour.r;
           }
           PImage image = new PImage();
           image.Set(buf, width, height, PImage.EPixelFormat.E_BGR8U);

           Assert.AreEqual(image.GetWidth(), width, "Image width not equal");
           Assert.AreEqual(image.GetHeight(), height, "Image height not equal");

           PImage image2 = new PImage(width, height, PImage.EPixelFormat.E_BGR8U);
           image2.Fill(colour);
           Assert.IsTrue(image.IsSame(image2));

        }

        [TestMethod]
        public void TestImageFromUserDataForMemory()
        {
            int width = 600;
            int height = 400;
            int depth = 3;
            var buf = new byte[width * height * depth];
            PColour3i colour = PColour3i.C_PINK;
            PImage image2 = new PImage(width, height, PImage.EPixelFormat.E_BGR8U);
            image2.Fill(colour);

            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < buf.Length; i += depth)
                {
                    buf[i] = (byte)colour.b;
                    buf[i + 1] = (byte)colour.g;
                    buf[i + 2] = (byte)colour.r;
                }
                PImage image = new PImage();
                image.Set(buf, width, height, PImage.EPixelFormat.E_BGR8U);
                Assert.IsTrue(image.IsSame(image2));
            }
        }    

    } // Test Class
} // namespace

