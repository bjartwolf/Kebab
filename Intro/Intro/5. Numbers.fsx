type num = Zero | OneMoreThan of num

Zero // what is my type?
let a = Zero
OneMoreThan Zero // and mytype)?
let two = (OneMoreThan (OneMoreThan Zero))
two

// make five with num!
// let five = 
// what is the type of five?

// What is the difference between Zero and 0
0 // what is my type?

//Are there more nums than bools?
//Are there more nums than positive ints?

// functions from recursive types tend to be recursive
let rec plus a b = match a with
                       | Zero -> b
                       | OneMoreThan n -> OneMoreThan (plus n b)

plus two two

let rec mult a b = match a with
                       | Zero -> Zero
                       | OneMoreThan n -> plus b (mult n b)

mult (plus two two) two

// What is the same in the definition of plus and mult?
// What is different?
// Can we make a function with the samey parts in it?

// (boilerplatey)
exception Nope
let wa _ = raise Nope
let t = ()

let rec numberwang z omt n = match n with
                                 | Zero -> z
                                 | OneMoreThan n -> omt (numberwang z omt n)

let plus' a b : num  = numberwang (wa t) (wa t) a
plus' two two

let mult' a b : num = numberwang (wa t) (wa t) a
mult' (plus two two) two


// (What are these things?)
type boolnum = Zero of bool | OneMoreThan of boolnum
Zero true

type intnum = Zero of int | OneMoreThan of intnum
Zero 0