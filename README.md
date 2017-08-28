# Papillon SWIG Wrappers

The [Papillon SDK](https://videoai.net/papillon) is a software development kit that allows easy integration 
of [Digital Barriers](https://www.digitialbarriers.com) world-class video and image processing software within applications. 
This includes Face Recognition, Face Detection, Intelligent Motion Detection, Alarm Verification and Camera Tampering detection.

The [Papillon SDK](https://videoai.net/papillon) SDK is written in C++ and assembler when required to be lightning fast.
It also will leverage the power of GPU's and multi-core CPUs when available.

However, these days many applications are written in higher level languages, such as Java, C# and Python.
In this repository are the tools and code that are required to generate bindings for other languages.
For this, we make extensive use of a great open-source application called [SWIG](http://www.swig.org).

## Prerequisite

The following developer tools must be installed:
- **Cmake 3.X**, an open-source, cross-platform, build tool (https://cmake.org/download/)
- **Swig 3.0.X** (http://www.swig.org)
- For Java: **Java Developer Kit 8** (JDK) (http://www.oracle.com/technetwork/java/javase/downloads/index.html)
- For C#: **Visual Studio 2013, 2015 or 2017 with C# environment**
- **Papillon SDK 4.X or higher** (https://cmake.org/download/), installed and working. Make sure you have the environment PAPILLON_INSTALL_DIR set-up properly. 

## Quick Start

### Choose the bindings to generate
Edit the `/home/xxx/_install/CMakeLists.txt` and at the end of the file, comment out the languages you do not wish to generate bindings for. 

### Windows environment:
- Open a command prompt (console)
- Go to your 'papillon-swig' folder
- Create and go to build directory: mkdir build & cd build
- Generate Visual Studio solution for your environment using cmake command line, see example below.
You will have to set path toward swig tool (replace PATH_SWIG by the appropriate path).
For example, for Visual Studio 2013 (64-bit):

```
cmake .. -G "Visual Studio 12 2013 Win64" -DSWIG_EXECUTABLE="PATH_SWIG\swig.exe" -DSWIG_DIR="PATH_SWIG\swigwin-3.0.12"
```

- Then, open Visual Studio solution file and compile the C# or Java library for your environment

### Linux environment:
Make sure the following environment variables are set in your _.bashrc_ file

```
export PAPILLON_INSTALL_DIR=/opt/Papillon
export LD_LIBRARY_PATH=/opt/Papillon/lib
```

To compile the wrappers...

```
mkdir build
cd build
cmake .. -DVERBOSE=1 -DCMAKE_INSTALL_PREFIX=/home/xxx/_install -DJAVA_PACKAGE=net.videoai.papillon
make
make install
```

You will also need to update your runtime library path.

```
export LD_LIBRARY_PATH=/opt/Papillon/lib:/home/xxx/_install/lib
```

## How to use wrappers?

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
export CLASSPATH=/home/xxx/_install/lib/java/PapillonCoreJava
cd /home/xxx/_install/lib/java/PapillonCoreJava
find -name "*.java" > sources.txt
javac @sources.txt
```

Next, if you want to run one of the examples you need to make sure the java interpreter can pick up these class files. 

```
cd /home/xxx/_install/examples/java
javac ExampleCoreImage.java
java -cp /home/xxx/_install/lib/java/PapillonCoreJava:. -Djava.library.path=/home/xxx/_install/lib ExampleCoreImage

```

### C#
When you run SWIG and CSharp a set of CSharp files are generated for each Papillon class.
When you compile one of the examples you need to include these files.
Alternatively, you can build a CSharp library from these files and include that in your project.

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

