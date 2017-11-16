# Papillon SWIG Wrappers

The [Papillon SDK](https://videoai.net/papillon) is a software development kit that allows easy integration 
of [Digital Barriers](https://www.digitialbarriers.com) world-class video and image processing software within applications. 
This includes Face Recognition, Face Detection, Intelligent Motion Detection, Alarm Verification and Camera Tampering detection.

The [Papillon SDK](https://videoai.net/papillon) SDK is written in C++ and assembler when required to be lightning fast.
It also will leverage the power of GPU's and multi-core CPUs when available.

However, these days many applications are written in higher level languages, such as Java, C# and Python.
In this repository are the tools and code that are required to generate bindings for other languages.
For this, we make extensive use of a great open-source application called [SWIG](http://www.swig.org).

Note, these wrappers are still experimental.

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
cmake .. -DVERBOSE=1 -DCMAKE_INSTALL_PREFIX=/home/xxx/_install
make
make install
```
It is possible to configure you own java package for java bindings. For example, add `-DJAVA_PACKAGE=net.videoai.papillon` to the cmake command. 

You will also need to update your runtime library path.

```
export LD_LIBRARY_PATH=/opt/Papillon/lib:/home/xxx/_install/lib
```

## How to use wrappers?

### Python

Note, we include the Python wrappers by default in the official Papillon SDK and ideally you should use these. These are the better tested as they are used to build all our face-recognition services.  However, if you wish to generate your own Python wrappers please following the instructions below.

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

When you run SWIG and JAVA a jar file is generated containing generated Java classes for each Papillon class.  A dynamic library is also generated.  These are copied over the installation directory. 

Note, the default package is `net.videoai.papillon.core`. 

Next, if you want to run one of the examples you need to make sure the java compiler/interpreter can pick up this jar file and the corresponding shared library.

Be sure you add the right import at the top of the example if you have specify a JAVA_PACKAGE to generate the bindings. 

```
cd /home/xxx/_install/examples/java
javac -cp .:../../lib/PapillonCoreJava.jar ExampleCoreImage.java
java -cp .:../../lib/PapillonCoreJava.jar -Djava.library.path=../../lib ExampleCoreImage

```

In a multi-threaded environment we have experienced some issues with a clash of symbols between the JVM and one of our plugins on Linux.  As a work-around you need to make sure our plugin symbol gets found first.  This can be done by setting the following environment variable.

```
export LD_PRELOAD=/opt/Papillon/plugins/libPPluginDescriberDnn.so
```

#### Java Memory Management

Java uses an automatic garbage collection process for memory management and this does not always work nicely with Swig generated wrappers.  In summary, it will depend how an Papillon object has been created.  For example, if the object has been created by a constructor or returned by value, Java will take ownership of the object and it will get automatically deleted by the garbage collector when it is out of scope.  However, when pointers or references are returned to Java, then Java does not take automatically take ownership and the objects will not be deleted.  In this case, you need to manually delete the object when it is no longer required.

For more information see the official [SWIG](http://www.swig.org/Doc3.0/Java.html#Java_memory_management) documentation.

### C#

When you run SWIG and CSharp a set of CSharp files are generated for each Papillon class.  When you compile one of the examples you need to include these files.  Alternatively, you can build a CSharp library from these files and include that in your project.

For example

```
cd /home/xxx/_install/examples/csharp/
mcs -unsafe -out:ExampleCoreImage.exe ../../lib/csharp/src/*.cs ExampleCoreImage.cs
./ExampleCoreImage.exe
```

### Ruby

This is still very experimental and you will need to turn this on in the main _CMakeList.txt_ file.

```  
export RUBYLIB=/home/xxx/_install/lib
```

