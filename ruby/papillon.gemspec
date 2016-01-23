Gem::Specification.new do |s|
  s.name        = 'papillon'
  s.version     = '0.1.2'
  s.licenses    = ['MIT']
  s.summary     = "Papillon SDK"
  s.description = "SWIG/C++ bindings for the Papillon SDK"
  s.authors     = ["VideoAI"]
  s.email       = 'info@videoai.net'
  s.files       = [
                    "Rakefile",
                    "ext/papillon/extconf.rb", 
                    "ext/papillon/papillon.cxx", 
                    "lib/papillon.rb", 
                    "lib/papillon/facedetect.rb"
                  ]
  s.homepage    = 'https://videoai.net'
  s.extensions  = %w[ext/papillon/extconf.rb]
end