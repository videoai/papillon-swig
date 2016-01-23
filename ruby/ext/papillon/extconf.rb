require 'mkmf'

sdk_install_dir = ENV['PAPILLON_INSTALL_DIR'] || '/opt/Papillon'

with_cflags("-x c++") do
  unless find_header('PapillonCore.h', sdk_install_dir + '/include/PapillonCore')
    abort "PapillonCore header files are missing. Please install the Papillon SDK."
  end
  unless find_library("PapillonCore", nil, sdk_install_dir + "/lib")
    abort "PapillonCore library files are missing. Please install the Papillon SDK."
  end
  create_makefile('papillon/papillon') 
end