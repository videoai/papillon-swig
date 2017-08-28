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
// This example shows how to use Papillon SDK in Java for Face Recognition 
//------------------------------------------------------------------------------


public class ExampleFaceRecognition {

    static {
        System.loadLibrary("PapillonCoreJava");
        PapillonSDK.Initialise();
    }

    public static PResult DoMatch(PDescription description1, PDescription description2, PVerify verify) {
        PMatchScore matchScore = new PMatchScore();
        verify.VerifyFromDescription(description1, description2, matchScore);
        // The match score returns a value between 0 and 1 with how likely the two descriptions are from the same identity,
        // with the higher score indicating a higher probably chance of the identities being the same.
        // Also, the match score is compared against an internal threshold that can be set in the verification engine.
        // If the match score is higher than the threshold, the identity is said to be verified (authenticated).
        if(matchScore.IsVerified()) {
           System.out.println("Passed Authentication '" + description1.GetName() + "' against '" + description2.GetName() + "' score = " + matchScore.GetScore());
        } else {
           System.out.println("Failed Authentication '" + description1.GetName() + "' against '" + description2.GetName() + "' score = " + matchScore.GetScore());
        }
        return PResult.getC_OK();
    }



    public static void main(String[] args) {
        String SAMPLE_DIR = PPath.Join(PUtils.GetEnv("PAPILLON_INSTALL_DIR"), "Data", "Samples");

    //===========
    // Enrollment
	//===========
    // Enrollment is the process of turning detected faces of a subject into a unique key.  In the biometrics world this is often
    // referred to as a biometric template.  In this SDK we prefer the use of the term 'description'.  Think of a description as a
    // description of an identity.  In this SDK descriptions are fairly generic containers which can be used to store
    // a lot of other information as well as the information about the face of the identity.
    // The enrollment engine wraps up the whole face-recognition processing chain into an easy to use interface.
    // From it you can easily generate 'descriptions' from images and videos.  However, all the functions provided
    // by the enrollment engine can also be done using the other classes available in this SDK as this enrollment
    // engine may not fit all use-cases.

	// The following code initialises an enrollment engine and sets it up with a set of sensible options
    PEnrollment enrollment = new PEnrollment();
    enrollment.AutoConfigureForFaceRecognition(); // this sets-up a sensible set of options for the face-rec enrollment

    // Now we can generate two different descriptions of Kieron using two images that were taken at different times.
    // For each image, the enrollment engine will locate the face in the input image and generate the description.
    // Note, if an image is supplied with more than face, then the enrollment function will generate an error, as it is
    // unsure which face to use for the enrollment.
    PGuid kieronSubjectId = PGuid.CreateUniqueId();
    PDescription descriptionOfKieron1 = new PDescription();
    enrollment.EnrollFromImage(PPath.Join(SAMPLE_DIR, "kieron01.jpg"), descriptionOfKieron1, "Kieron", kieronSubjectId);

    PDescription descriptionOfKieron2 = new PDescription();
    enrollment.EnrollFromImage(PPath.Join(SAMPLE_DIR, "kieron02.jpg"), descriptionOfKieron2, "Kieron", kieronSubjectId);

    // Generate two descriptions of Kjetil from images taken at different times
    PGuid kjetilSubjectId = PGuid.CreateUniqueId();
    PDescription descriptionOfKjetil1 = new PDescription();
    enrollment.EnrollFromImage(PPath.Join(SAMPLE_DIR, "kjetil01.jpg"), descriptionOfKjetil1, "Kjetil", kjetilSubjectId);
    
    PDescription descriptionOfKjetil2 = new PDescription();
    enrollment.EnrollFromImage(PPath.Join(SAMPLE_DIR, "kjetil02.jpg"), descriptionOfKjetil2, "Kjetil", kjetilSubjectId);
        
    //===========================================================
    // Face Verification on Images (also known as Authentication)
    //===========================================================
    // Verification (commonly referred to as Authentication) is the process of comparing two identities (using their
    // 'descriptions' and comparing the result against a threshold. If the probability of match is higher than the
    // threshold, then the identity is said to be Verified/Authenticated.
    // The value of the threshold can be set using some pre-defined security levels.  Alternatively, it can be set
    // manually by specifying the value yourself.  Care should be taken in setting the right value for your application.
    // Papillon has a verification engine which is a helper class to enable you to easily perform verification on descriptions, images
    // and videos.  All the functionalities of this class can also be done by using the other classes available in
    // the SDK.

    // The following code, initialises the verification engine, using the enrollment engine and sets the security level.
    PVerify verify = new PVerify(enrollment, EVerificationSecurityLevel.E_VERIFICATION_SECURITY_LEVEL_HIGH);
    // Next we can try to match a description of Kieron against another description of Kieron, we would expect this to authenticate
    // successfully with a high probability.
    DoMatch(descriptionOfKieron1, descriptionOfKieron2, verify);
    // However, if we match a description of Kieron against a description of Kjetil, we would NOT expect this to authenticate
    // successfully.  The probability of match will be low.
    DoMatch(descriptionOfKieron1, descriptionOfKjetil1, verify);
    // We can also match a description of Kjetil against another description of Kjetil.  Again, we would expect this to authenticate
    // successfully with a high probability.
    DoMatch(descriptionOfKjetil1, descriptionOfKjetil2, verify);


    //===========================
    // Face Verification on Video
    //===========================
    // Next lets perform enrollment from a video.  This is done by processing each frame of the video in turn.
    // Because videos can contain multiple faces of the same identity in frames, a collection of faces
    // can be used to generate the description.  The number of frames to process and the number of examples
    // to used to generate the description can be specified as parameters.
    // Note, only supply videos which are known to have a single identity present when performing enrollment.
    // If you have multiple faces in your video then you need to use the FaceLog2 analytic to generate descriptions
    // to use for enrollment.
    int maxFramesToProcess = -1; // Process all the frames (up until the maxExamples has been reached)
    int maxExamples = 10; // Use the first 5 examples found in the video to generate the description.

    PDescription descriptionOfKieronFromVideo = new PDescription();
    enrollment.EnrollFromVideo(PPath.Join(SAMPLE_DIR, "kieron01.avi"),
        descriptionOfKieronFromVideo, maxFramesToProcess, maxExamples, "Kieron in Video", kieronSubjectId);
    PDescription descriptionOfKjetilFromVideo = new PDescription();
    enrollment.EnrollFromVideo(PPath.Join(SAMPLE_DIR, "kjetil01.avi"),
        descriptionOfKjetilFromVideo, maxFramesToProcess, maxExamples, "Kjetil in Video", kjetilSubjectId);

    // Should authenticate
    DoMatch(descriptionOfKieron2, descriptionOfKieronFromVideo, verify);
    // Should fail to authenticate
    DoMatch(descriptionOfKjetil1, descriptionOfKieronFromVideo, verify);
    // Should authenticate
    DoMatch(descriptionOfKjetil1, descriptionOfKjetilFromVideo, verify);
    // Should fail to authenticate
    DoMatch(descriptionOfKieron2, descriptionOfKjetilFromVideo, verify);


    // =============================
    // Merging Descriptions Together
    //==============================
    // In the above, 5 examples from the video have been used to build each description.
    // Each example used has been turned into a descriptor.
    // When enrolling from the image, only a single example face was used to generate the description.
    // The description will only contain 1 descriptor
    // We can see this by requesting the number of descriptors each description holds.
    System.out.println("Number of descriptors in image description: " + descriptionOfKieron1.GetDescriptors().Size());
    System.out.println("Number of descriptors in video description: " + descriptionOfKieronFromVideo.GetDescriptors().Size());

    // When a description is generated a thumbnail for each example (descriptor) is generated and stored in the description
    // We can get to these thumbnails and display them
    PImage thumbnail = new PImage();
    PList thumbnails = descriptionOfKieron1.GetThumbnails();
    thumbnails.Get(0, thumbnail);
    thumbnail.Display("Thumbnail Of Kieron", 5000); // display for 5 seconds


    // It is possible to merge descriptions of the same identity together, generating a more complete 'description' of someone
    if(descriptionOfKieron1.AddDescription(descriptionOfKieron2).Failed()) {
    	System.err.println("Failed to merge descriptions");
        System.exit(0);
    }
    // We would now expect there to be two descriptors in the description
    // Note, if you try to merge two descriptions with different IdentityId's together this will still work.
    // However, the id of base description will be used and the other discarded
    System.out.println("Number of descriptors in description: " + descriptionOfKieron1.GetDescriptors().Size());


    // Now when we perform the comparison, the match score could change as there is more information
    // held in one of the descriptions.  You will notice the confidence has increased as we are more
    // certain the two identities are the same.
    DoMatch(descriptionOfKieron1, descriptionOfKieronFromVideo, verify);

    // We now also have two thumbnails associated with this description
    thumbnails = descriptionOfKieron1.GetThumbnails();
    System.out.println("Number of thumbnails in description: " + thumbnails.Size());
    thumbnails.Get(0, thumbnail);
    thumbnail.Display("Thumbnail 1 Of Kieron", 5000); // display for 5 seconds
    thumbnails.Get(1, thumbnail);
    thumbnail.Display("Thumbnail 2 Of Kieron", 5000); // display for 5 seconds

    // ============================
    // Description Input and Output
    //=============================
    // It is easy to save any Papillon object to file, including descriptions
    if(PFileIO.WriteToFile("descriptionOfKieron1.bin", descriptionOfKieron1).Failed()) {
    	System.err.println("Failed to save description to file");
        System.exit(0);
    }
    if(PFileIO.WriteToFile("descriptionOfKieronFromVideo.bin", descriptionOfKieronFromVideo).Failed()) {
    	System.err.println("Failed to save description to file");
        System.exit(0);
    }

    // We can also easily match descriptions that are stored in file
    PMatchScore matchScore = new PMatchScore();
    if(verify.VerifyFromDescriptionFile("descriptionOfKieron1.bin", "descriptionOfKieronFromVideo.bin", matchScore).Failed()) {
    	System.err.println("Failed to match descriptions from file");
        System.exit(0);
    }
    System.out.println("Match Score " + matchScore);

    // A common requirement is to save descriptions in a database such as MySQL, Postgresql, redis ....
    // This can easily be done using memory streams which allows a binary representation of a papillon
    // For example to get a binary blob of a description...
    PMemoryStream ms = new PMemoryStream();
    ms.WriteObjectDescription(descriptionOfKieron1);
    PByteArray byteArray = ms.GetByteArray();
    System.out.println("Description size in bytes: " + byteArray.Size());
    // Also, you can also convert the object to a string which can be stored as a text row of a database table
    String str = byteArray.ToString();

    // To get from the string back to the byte-array back to your original object you perform the reverse operation
    PByteArray byteArray2 = new PByteArray();
    PByteArray.FromString(str, byteArray2);
    // and then back to the description
    PDescription descriptionFromString = new PDescription();
    PMemoryStream ms2 = new PMemoryStream(byteArray2);
    ms2.ReadObjectDescription(descriptionFromString);

    // And we can do our comparison and should get the same match score as before
    // and get to the thumbnail
    DoMatch(descriptionFromString, descriptionOfKieronFromVideo, verify);
    thumbnails = descriptionFromString.GetThumbnails();
    thumbnails.Get(0, thumbnail);
    thumbnail.Display("Kieron Again", 5000);


    //===================================
    // Face Identification and Watchlists
    //===================================
    // Face identification is the process of ascertaining the identity by comparing it against a list of known identities.
    // This is done by comparing the 'unknown' description (often referred to as a probe) against a watchlist (sometimes referred
    // to as a gallery) of known descriptions and returning the top N matches, that pass the threshold value.
    // In Papillon we have a watchlist class that enables you to perform identification.
    PWatchlist watchlist = new PWatchlist();

    // You can add descriptions to the watchlist
    // The descriptions of Kieron
    watchlist.Add(descriptionOfKieron1);
    watchlist.Add(descriptionOfKieron2);
    // The descriptions of Kjetil
    watchlist.Add(descriptionOfKjetil1);
    watchlist.Add(descriptionOfKjetil2);

    // To get the size of the watchlist
    // Note, this returns the number of subjects, not the number of descriptions.
    System.out.println("Watchlist Size: " + watchlist.Size());

    // To search a watch list you need to specify a comparer to use and threshold level to use
    PComparer comparer = new PComparer();
    PComparer.Create(comparer, 0.55);

    // Lets generate an unknown description
    PDescription unknownDescription = new PDescription();
    enrollment.EnrollFromImage(PPath.Join(SAMPLE_DIR, "kieron_20_years_ago.jpg"), unknownDescription);

    // And run a search against the watchlist
    PIdentifyResults identifyResults = new PIdentifyResults();
    watchlist.Search(unknownDescription, comparer, identifyResults, 1, 0.55f);

    // In this example, the identity is returned as Kieron, eventhough there is over a 20 year gap
    // between the times the photos were taken
    System.out.println(identifyResults.ToString());
    thumbnails=unknownDescription.GetThumbnails();
    thumbnails.Get(0, thumbnail);
    thumbnail.Display("Kieron 20 Years Ago", 5000);

    // We can of course load and save watchlists as well
    PFileIO.WriteToFileWatchlist("watchlist.bin", watchlist);

    //=============================
    // Face Identification in Video
    //=============================
    // There is another example which deals with the complicated task of performing face-identification in video.
    // This example is ExampleFaceLog2.cc

            


    }

}

