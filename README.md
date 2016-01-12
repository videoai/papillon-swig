# papillon-swig
Swig wrappers for the Papillon SDK.  You will need the latest version of the Papillon SDK installed.

This is still WIP (work in progress).  The Python wrappers are the best tested.

To compile the wrappers...

'''
mkdir build
cd build
cmake .. -DVERBOSE=1 -DCMAKE_INSTALL_PREFIX=/home/xxx/_install
make
make install
'''

Then set up your environment...

export LD_LIBRARY_PATH=/opt/Papillon/lib:/home/xxx/_install/lib
export PYTHONPATH=/home/xxx/_install/lib
export RUBYLIB=/home/xxx/_install/lib

Then you can try to run some of the examples.
