# Papillon SWIG Wrappers

The [Papillon SDK](https://videoai.net/papillon) is a software development kit that allows easy integration of [Digital Barriers](https://www.digitialbarriers.com) world-class video and image processing software within applications.  This includes Face Recognition, Face Detection, Intelligent Motion Detection, Alarm Verification and Camera Tampering detection.

The [Papillon SDK](https://videoai.net/papillon) SDK is written in C++ and assembler when required to be lighting fast.  It also will leverage the power of GPU's and multi-core CPUs when available.

However, these days many applications are written in higher level languages such as Java, CSharp and Python.  In this repository are the tools and code required to generate bindings for other languages.  For this we make extensive of a great opensource tool called [SWIG](http://www.swig.org).

## Quick Start

You will need the latest version of the [Papillon SDK](https://videoai.net/papillon) installed and working.  Make sure you have the environment set-up properly. 

Make sure the following environment variables are seti in your _.bashrc_ file

```
export PAPILLON_INSTALL_DIR=/opt/Papillon
export LD_LIBRARY_PATH=/opt/Papillon/lib
```

To compile the wrappers...

```
mkdir build
cd build
cmake .. -DVERBOSE=1 -DCMAKE_INSTALL_PREFIX=/home/xxx/_install
make
make install
```

You will also need to update your runtime library path.

```
export LD_LIBRARY_PATH=/opt/Papillon/lib:/home/xxx/_install/lib
```


### Python

To use the Python wrappers you need to update your _PYTHONPATH_.

```  
export PYTHONPATH=/home/xxx/_install/lib
```

You then can run the examples.

```
cd /home/xxx/_install/examples/python
python PapillonCoreExample.py
python PapillonFaceDetect.py
```

### Java

When you run SWIG and JAVA a set of Java files are generated for each Papillon class.  With your favourite Java compiler you need to turn these into class files. For example,

```
export CLASSPATH=/home/xxx/_install/lib/java/PapillonJava
cd /home/xxx/_install/lib/java/PapillonJava
javac *.java
```

Next, if you want to run one of the examples you need to make sure the java interpreter can pick up these class files. 

```
cd /home/xxx/_install/examples/java
javac ExampleCoreImage.java
java -cp /home/xxx/_install/lib/java/PapillonJava:. -Djava.library.path=/home/xxx/_install/lib ExampleCoreImage

```

### CSharp 
When you run SWIG and CSharp a set of CSharp files are generated for each Papillon class.  When you compile one of the examples you need to include these files.  Alternatively, you can build a CSharp library from these files and include that in your project.

For example

```
cd /home/xxx/_install/examples/csharp/
mcs -unsafe -out:ExampleCoreImage.exe ../../lib/csharp/src/*.cs ExampleCoreImage.cs
./ExampleCoreImage.exe
```


### Ruby

This is still experimental and you will need to turn this on in the main _CMakeList.txt_ file.

```  
export RUBYLIB=/home/xxx/_install/lib
```

