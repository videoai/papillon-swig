# papillon-swig
Swig wrappers for the Papillon SDK.  You will need the latest version of the Papillon SDK installed and working.  Make sure you have the environment set-up properly.

```
export PAPILLON_INSTALL_DIR=/opt/Papillon
```

To compile the wrappers...

```
mkdir build
cd build
cmake .. -DVERBOSE=1 -DCMAKE_INSTALL_PREFIX=/home/xxx/_install
make
make install
export LD_LIBRARY_PATH=/opt/Papillon/lib:/home/xxx/_install/lib
```

# Python


```  
export PYTHONPATH=/home/xxx/_install/lib
```

To run the examples.

```
cd /home/xxx/_install/examples/python
python PapillonCoreExample.py
python PapillonFaceDetect.py
```

# Java

When you run SWIG and JAVA a set of Java files are generated for each Papillon class.  With your favourite Java compiler you need to turn these into class files. For example,

```
export CLASSPATH=/home/xxx/_install/lib/java/PapillonJava
cd /home/xxx/_install/lib/java/PapillonJava
javac *.java
```

Next, if you want to run one of the examples

```
cd /home/xxx/_install/examples/java
javac ExampleCoreImage.java
java -cp /home/xxx/_install/lib/java/PapillonJava:. -Djava.library.path=/home/xxx/_install/lib ExampleCoreImage

```


# Ruby

```  
export RUBYLIB=/home/xxx/_install/lib
```

