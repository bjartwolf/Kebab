// ctrl+enter to send line or selection to fsi/repl
// reset fsi by rightcliking in the F# Interactive and click reset


type num<'A>  = Zero of 'A | OneMoreThan of num<'A>


// can you make some zero with false, Five with your name and two of 1 (as in the int)


// Bonus...
// What am I? let weirdo = OneMoreThan( Zero ( OneMoreThan( OneMoreThan( Zero 1))))
