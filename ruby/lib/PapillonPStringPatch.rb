# The current SWIG interface file for Ruby produces a broken version of the 
# Papillon::PString class, which needs to be patched in order to work. 

# Currently it still produces garbled output to the console, but as far as I can
# see, functionality actually works.

# There is one other caveat however. Strings don't compare well with the current
# state, and thus this:
#
#   Papillon::PDetector::Create(
#     Papillon::PString.new("FaceDetector"), 
#     Papillon::PString.new(""), 
#     detector).OrDie()
#
# will die. The PString that's being used has to be clipped manually, i.e.: 
#
#   Papillon::PString.new("FaceDetector").Substring(0, "FaceDetector".length)
#
# which I've not bothered to incorporate in the patch below.


class Papillon::PString
  alias_method :old_initialize, :initialize
  alias_method :old_c_str, :c_str
  
  def initialize(string)
    old_initialize(string.encode("UTF-32le"))
  end
  
  def c_str
    old_c_str.force_encoding("UTF-8")
  end
end