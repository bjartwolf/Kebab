# Kebabs with VSCode
The Visual Studio Code (VSCode) version of the original [Kebab workshop](https://github.com/bjartwolf/Kebab)

Little ML'er in F# - a workshop.
The reason for its name might become more clear if you do some of the exercices and/or read the book.

Used for workshops at flatMap(Oslo) and some universities and meetups...

The exercies are based on this book, you should buy it if you are interested in knowing more about this and getting the proper explanations. 
http://www.amazon.com/The-Little-MLer-Matthias-Felleisen/dp/026256114X

![image](https://mitpress.mit.edu/sites/default/files/9780262561143.jpg)

# Setup

The workshop will be given i Visual Studio Code, but the excercises will work in both Visual Studio and MonoDevelop as well.

## TODO Using the Virtual Machine

The simplest way to get started with the workshop, is to use the pre-prepared viritual machine.

The workshop is distributed in a 32-bit Ubuntu VM OWA 1.0 format, that can be imported into VirtualBox: 
* The VM can be downloaded from [http://virtualmachinesshare.blob.core.windows.net/virtualmachines/smarf.ova](http://virtualmachinesshare.blob.core.windows.net/virtualmachines/smarf.ova).
* The password and username is **smarf** and **smarf**.
* If the machine runs slow, or Mono autocompletion is slow, try to allocate more CPUs, RAM, Video RAM etc to the machine. Maybe it helps.
 
## Manual Setup

If you don't want to use a viritual machine, you'll need to get F#, Visual Studio Code and the Ionide plugin.
Follow the F# Software Foundation's installation guide for [linux](http://fsharp.org/use/linux/), [mac](http://fsharp.org/use/mac/) or [windows](http://fsharp.org/use/windows/).

### Getting wierd F#-output in VSCode?

Ionide has a known bug, that can cause weird output in the F# terminal on some installations.
If you experience this, include the following in your VS Code settings file:

    "terminal.integrated.flowControl": false

# Exercises

The box also comes with the [http://www.fsharpworkshop.com/](http://www.fsharpworkshop.com/) exercices in the ~/fsharpworkshop folder, not a part of the Little ML'er workshop, but an excellent workshop if you want to learn more about F#. The Little ML'er focuses more on types and not so much on the other aspects of the language.

## Intro

Open the intro solution. This part is just scripts and is meant to be evaluated and played with in FSI. Send a line to FSI using CTRL+ENTER in MonoDevelop. There is no feedback on right and wrong, ask an instructor or ask @jonaswinje, @einarwh or @bjartnes or someone else on Twitter if  you are not sure, or create a GitHub issue or something. The assignments are a bit open on purpose. We want you to play with the concepts.

## Trees

This solution is a bit more like a traditional .NET project and is compiled and tested either using the build-script or using CTRL+T in MonoDevelop to run tests. It includes property-based testing and more complex types.
