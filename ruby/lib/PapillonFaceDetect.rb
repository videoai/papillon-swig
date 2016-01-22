$:.unshift File.dirname(__FILE__)
# Either the generated Ruby bindings (papillon.so) need to be in the current 
# directory of this file, or papillon needs to be installed as a gem.
require 'papillon'
require 'PapillonPStringPatch'

module Papillon
  extend self

  def FaceDetect(input_video, output_video, opts = {})
    opts = {
      :input_video        => input_video,
      :output_video       => output_video,
      :app_name           => "Papillon Interface #{self.__id__}",
      :debug              => false,
      :localiser          => 0,
      :min_detection_size => 30,
      :threshold          => 0.0
    }.merge(opts)

    Papillon::PapillonSDK::Initialise(Papillon::PString.new(opts[:app_name])).OrDie()
    Papillon::PLog::OpenConsoleLogger() if opts[:debug]

    inputStream = Papillon::PInputVideoStream.new
    outputStream = Papillon::POutputVideoStream.new()
    Papillon::PInputVideoStream::Open(Papillon::PString.new(opts[:input_video]), inputStream).OrDie()
    Papillon::POutputVideoStream::Open(Papillon::PString.new(opts[:output_video]), outputStream).OrDie()

    detector = Papillon::PDetector.new
    facedetectorstring = Papillon::PString.new("FaceDetector").Substring(0, "FaceDetector".length)
    Papillon::PDetector::Create(facedetectorstring, Papillon::PString.new(""), detector).OrDie()

    detectorOptions = Papillon::PDetectorOptions.new
    detectorOptions.SetIntParameter(Papillon::PString.new("LOCALISER"), opts[:localiser])
    detectorOptions.SetMinDetectionSize(opts[:min_detection_size])
    detectorOptions.SetThreshold(opts[:threshold])

    detectionList = Papillon::PDetectionList.new
    frame = Papillon::PFrame.new
    while(inputStream.GetFrame(frame).Ok())
      detector.Detect(frame, detectorOptions, detectionList)
      image = frame.GetImage()
      Papillon::PUtils::DrawDetectionList(image, detectionList)
      outputStream.PutImage(image)
    end
  end
end
