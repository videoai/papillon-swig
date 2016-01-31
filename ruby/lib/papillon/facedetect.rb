require File.join(File.dirname(__FILE__), '..', 'papillon')

module Papillon
  extend self

  def FaceDetect(input_video, output_video, opts = {})
    opts = standard_options.merge({
      :input_video        => input_video,
      :output_video       => output_video,
    }).merge(opts)

    initialise_sdk opts[:app_name], opts[:debug]
    
    input_stream  = open_input_video_stream opts[:input_video]
    output_stream = open_output_video_stream opts[:output_video], opts[:output_encode_with]
    (detector, doptions) = setup_detector 'FaceDetector', opts

    detectionList = Papillon::PDetectionList.new
    frame = Papillon::PFrame.new
    while(input_stream.GetFrame(frame).Ok)
      detector.Detect(frame, doptions, detectionList)
      image = frame.GetImage()
      Papillon::PUtils::DrawDetectionList(image, detectionList)
      output_stream.PutImage(image)
    end
  end
  
  private
  
  def standard_options
    {
      :app_name           => "Papillon Interface #{self.__id__}",
      :debug              => false,
      :localiser          => 0,
      :min_detection_size => 30,
      :threshold          => 0.0,
      :output_encode_with => 'encode_with=opencv&fourcc=H264'
    }
  end
  
  def initialise_sdk app_name, debug
    initialised = Papillon::PapillonSDK::Initialise(s(app_name))
    unless initialised.Ok
      raise Papillon::Error.new('Unable to initialise Papillon SDK!')
    end
    Papillon::PLog::OpenConsoleLogger if debug
  end
    
  def open_input_video_stream file_path
    stream = Papillon::PInputVideoStream.new
    result = Papillon::PInputVideoStream::Open(s(file_path), stream)
    unless result.Ok
      raise Papillon::Error.new('Unable to open input video stream!')
    end
    stream
  end
  
  def open_output_video_stream file_path, encode_with
    file_path = file_path + '?' + encode_with
    stream = Papillon::POutputVideoStream.new
    result = Papillon::POutputVideoStream::Open(s(file_path), stream)
    unless result.Ok
      raise Papillon::Error.new('Unable to open output video stream!')
    end
    stream
  end
  
  def setup_detector product, opts
    detector = Papillon::PDetector.new
    result = Papillon::PDetector::Create(s(product), s(''), detector)
    unless result.Ok
      raise Papillon::Error.new('Unable to create detector!')
    end
    doptions = Papillon::PDetectorOptions.new
    doptions.SetIntParameter(s('LOCALISER'), opts[:localiser])
    doptions.SetMinDetectionSize(opts[:min_detection_size])
    doptions.SetThreshold(opts[:threshold])
    [detector, doptions]
  end
  
  class Error < RuntimeError; end
end
