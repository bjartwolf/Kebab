﻿// reset fsi by rightcliking in the F# Interactive and click reset to make sure you get rid of the old definitions...
type num<'A>  = Zero of 'A | OneMoreThan of num<'A>


// can you make some zero with false, Five with your name and two of 1 (as in the int)


// Bonus...
// What am I? let weirdo = OneMoreThan( Zero ( OneMoreThan( OneMoreThan( Zero 1))))