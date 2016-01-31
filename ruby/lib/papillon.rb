require 'papillon/papillon'

# ---- start Papillon::PString patch

# The current SWIG interface file for Ruby produces a broken version of the 
# Papillon::PString class, which needs to be patched in order to work. 
#
# Until the SWIG interface file is fixed appropriately, please use the method
# s() on the Papillon module to generate PStrings, e.g.:
# 
# Papillon.s("my string")
#
# See also the examples in this package for more information.
# 

module Papillon
  extend self
  
  def s string
    Papillon::PString.new(string).Substring(0, string.length)
  end
end

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
# ---- end Papillon::PString patch
