// ctrl+enter to send line or selection to fsi/repl
// reset fsi by rightcliking in the F# Interactive and click reset
exception Nope
let wa _ = raise Nope
let t = ()

type fruit = Apple | Pear

type meat = Beef | Mutton


// food is a Plate of whatever...
type food<'A> = Plate of 'A

// what is the type of..?
Plate Apple
Plate Mutton

let isBeef f =
    match f with
        | Plate Beef -> true
        | Plate Mutton -> false

isBeef (Plate Beef)


type box<'A> = Box of 'A

Box 1

// can you make a box<food<fruit>>?
// can you make a function from food<meat> to box<fruit>?



type either<'A, 'B> = Left of 'A | Right of 'B

let fruitOrMeat1 : either<fruit, meat> = Left Apple

// can you make a either<fruit, meat> using the Right constructor?
let fruitOrMeat2 : either<fruit, meat> = wa t

// can you make an either<food<meat>, box<fruit>>?
// (and can you make one using the Left constructor and one using the Right?)




type num<'A>  = Zero of 'A | OneMoreThan of num<'A>


// can you make some zero with false, Five with your name and two of 1 (as in the int)


// Bonus...
// What am I? let weirdo = OneMoreThan( Zero ( OneMoreThan( OneMoreThan( Zero 1))))
