require 'papillon'


#print Papillon.constants.select {|c| Class === Papillon.const_get(c)}

t = "Hello World!"
puts t

# now lets make papillon string
s = Papillon::PString.new("joke is on me")

# why does this not print properly is beyond me....
puts s.c_str()
puts s.Size() 


