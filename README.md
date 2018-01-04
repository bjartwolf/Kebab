# Kebabs

Little ML'er in F# - a workshop.
The reason for its name might become more clear if you do some of the exercises and/or read the book.

The exercises are based on this book, you should buy it if you are interested in knowing more about this and getting the proper explanations. 
http://www.amazon.com/The-Little-MLer-Matthias-Felleisen/dp/026256114X

![image](https://mitpress.mit.edu/sites/default/files/9780262561143.jpg)

# Setup

The workshop will be given i Visual Studio Code using the Ionide plugin.

## Manual Setup

You need to get F#, Visual Studio Code and the Ionide plugin.
Follow the F# Software Foundation's installation guide for [linux](http://fsharp.org/use/linux/), [mac](http://fsharp.org/use/mac/) or [windows](http://fsharp.org/use/windows/).

### Getting weird F#-output in VSCode?

Ionide has a known bug, that can cause weird output in the F# terminal on some installations.
If you experience this, include the following in your VS Code settings file:

```
{
    "terminal.integrated.flowControl": false
}
```

You can open the settings-file by pressing Ctrl + Shift + P and writing Open User Settings.

### Love those custom keybindings?

If you want to move the cursor to the fsi-repl in VSCode without using a pointer device, you'll need a custom keybinding.
Press Ctrl + K, Ctrl + S to open the user keybindings and enter the following to bind Ctrl + 4 to go to fsi-repl.

```
[
    {
        "key": "ctrl+4",
        "command": "workbench.action.terminal.focus",
        "when": "editorTextFocus"
    }
]
```

### Property based assignments 
They require paket to install FSCheck. https://github.com/ionide/ionide-vscode-paket

Run > Paket:install  (CTRL+SHIFT+P   Paket install) to install required depedencies.

# Assignments

The scripts in the assignments folder is meant to be evaluated and played with in FSI. Send a line to FSI using alt + enter in VSCode. There is no feedback on right and wrong, ask an instructor or ask @jonaswinje or @_teodoran or someone else on Twitter if  you are not sure, or create a GitHub issue or something. The assignments are a bit open on purpose. We want you to play with the concepts.
