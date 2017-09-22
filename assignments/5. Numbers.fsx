// alt + enter to send line or selection to fsi/repl
// Reset fsi by clicking on "Kill Terminal" (the garbage can icon) in the VS Code terminal


// (boilerplatey)
exception Nope
let wa _ = raise Nope
let t = ()

// meep:

type num = Zero | OneMoreThan of num

Zero // what is my type?
let a = Zero
OneMoreThan Zero // and mytype)?
let two = OneMoreThan (OneMoreThan Zero)
two

// make five with Zero and OneMoreThan
// let five = 
// what is the type of five?

// What is the difference between Zero and 0
0 // what is the type of 0?

//Are there more nums than bools?
//Are there more nums than positive ints?

// functions from recursive types tend to be recursive
let rec plus a b =
  match a with
  | Zero -> b
  | OneMoreThan n -> OneMoreThan (plus n b)

plus two two


// replace (wa t) with stuff to make a multiplication-function
let rec mult a b : num =
  match a with
  | Zero -> (wa t)
  | OneMoreThan n -> (wa t)

mult (plus two two) two



// Extra bonus difficult things:
//
// What is the same in the definition of plus and mult?
// What is different?
// Can we make a function with the samey parts in it?

let rec foldNumber z omt n =
  match n with
  | Zero -> z
  | OneMoreThan n -> omt (foldNumber z omt n)

// foldNumber checks if the number is Zero or OneMoreThan something, recursively like,
// and does one thing for Zero case and another thing for OneMoreThan case.
// We need to pass in what to do, or return, for the Zero case: The z argument.
// And what to do for the OneMoreThan case: The omt argument.
// And then, maybe later, the number we wanna work on: The n argument.

let plus' a b : num  = foldNumber (wa t) (wa t) a
plus' two two

let mult' a b : num = foldNumber (wa t) (wa t) a
mult' (plus two two) two
