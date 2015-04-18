# Kebab
Little ML'er in F#

Planning to use this for a workshop

You should buy the book
http://www.amazon.com/The-Little-MLer-Matthias-Felleisen/dp/026256114X

![image](https://mitpress.mit.edu/sites/default/files/9780262561143.jpg)

The workshop is distributed in a 32-bit Ubuntu VM OWA 1.0 format, that can be imported into VirtualBox on 
The VM can be downloaded from [http://virtualmachinesshare.blob.core.windows.net/virtualmachines/smarf.ova](http://virtualmachinesshare.blob.core.windows.net/virtualmachines/smarf.ova). The reason for running it on Ubuntu is that it can be distributed without licenses restricting its use. 

The assignments are designed to work both in Visual Studio and MonoDevelop. The reason they are set up with Ubunut and Mono is that it allows for free distribution of the virtual machines.

If the machine runs slow, or Mono autocompletion is slow, try to allocate more CPUs, RAM, Video RAM etc to the machine. Maybe it helps.

The password and username is smarf and smarf. 

# Exercises

The box also comes with the [http://www.fsharpworkshop.com/](http://www.fsharpworkshop.com/) exercices in the ~/fsharpworkshop folder, not a part of the Little ML'er workshop, but an excellent workshop if you want to learn more about F#. The Little ML'er focuses more on types and not so much on the other aspects of the language.

## Intro

Open the intro solution. This part is just scripts and is meant to be evaluated and played with in FSI. Send a line to FSI using CTRL+ENTER in MonoDevelop. There is no feedback on right and wrong, as an instructor or ask @jonaswinje, @einarwh or @bjartnes or someone else on Twitter if  you are not sure, or create a GitHub issue or something. The assignments are a bit open on purpose. We want you to play with the concepts.

## Trees

This solution is a bit more like a traditional .NET project and is compiled and tested either using the build-script or using CTRL+T in MonoDevelop to run tests. It includes property-based testing and more complex types.




