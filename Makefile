
# Make the VS2017 solution files in the build folder
sln: clean
	cmake . -G "Visual Studio 15 2017 Win64" -B build
	
# On VS2017 the indexing seems broken.  After doing the initial compile of the libraries and examples you need
# to shut down Visual Studio and manually delete the index it has made.
# When you restart VS2017 it will re-index the code and the syntax highlighting and code completion should work again.
rm-index:
	rm -rf .vs
	
clean:
	rm -rf build/*
