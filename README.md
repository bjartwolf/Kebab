# Kebabs with VSCode
The Visual Studio Code (VSCode) version of the original [Kebab workshop](https://github.com/bjartwolf/Kebab)

Little ML'er in F# - a workshop.
The reason for its name might become more clear if you do some of the exercises and/or read the book.

The exercises are based on this book, you should buy it if you are interested in knowing more about this and getting the proper explanations. 
http://www.amazon.com/The-Little-MLer-Matthias-Felleisen/dp/026256114X

![image](https://mitpress.mit.edu/sites/default/files/9780262561143.jpg)

# Setup

The workshop will be given i Visual Studio Code.

## TODO Using the Virtual Machine

The simplest way to get started with the workshop, is to use the pre-prepared virtual machine.

The workshop is distributed as a 64-bit Ubuntu ISO disk image, that can be imported into VirtualBox: 
* The VM can be downloaded from [TODO](TODO).
* The password and username is **kebab** and **kebab**.
* If the machine runs slow, or Mono autocompletion is slow, try to allocate more CPUs, RAM, Video RAM etc to the machine. Maybe it helps.
 
## Manual Setup

If you don't want to use a virtual machine, you'll need to get F#, Visual Studio Code and the Ionide plugin.
Follow the F# Software Foundation's installation guide for [linux](http://fsharp.org/use/linux/), [mac](http://fsharp.org/use/mac/) or [windows](http://fsharp.org/use/windows/).

### Getting wierd F#-output in VSCode?

Ionide has a known bug, that can cause weird output in the F# terminal on some installations.
If you experience this, include the following in your VS Code settings file:

    "terminal.integrated.flowControl": false

# Assignments

The scripts in the assignments folder is meant to be evaluated and played with in FSI. Send a line to FSI using alt + enter in VSCode. There is no feedback on right and wrong, ask an instructor or ask @jonaswinje or @_teodoran or someone else on Twitter if  you are not sure, or create a GitHub issue or something. The assignments are a bit open on purpose. We want you to play with the concepts.
