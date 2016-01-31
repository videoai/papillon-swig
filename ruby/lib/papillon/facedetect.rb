require File.join(File.dirname(__FILE__), "..", "papillon")

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

    Papillon::PapillonSDK::Initialise(s(opts[:app_name])).OrDie()
    Papillon::PLog::OpenConsoleLogger() if opts[:debug]

    inputStream = Papillon::PInputVideoStream.new
    outputStream = Papillon::POutputVideoStream.new()
    Papillon::PInputVideoStream::Open(s(opts[:input_video]), inputStream).OrDie()
    Papillon::POutputVideoStream::Open(s(opts[:output_video]), outputStream).OrDie()

    detector = Papillon::PDetector.new
    Papillon::PDetector::Create(s("FaceDetector"), s(""), detector).OrDie()

    detectorOptions = Papillon::PDetectorOptions.new
    detectorOptions.SetIntParameter(s("LOCALISER"), opts[:localiser])
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
