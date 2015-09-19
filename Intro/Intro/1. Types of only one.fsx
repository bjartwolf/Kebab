// ctrl+enter to send line or selection to fsi/repl
// reset fsi by rightcliking in the F# Interactive and click reset


// Defining a type in F#

type salt = Salt
// "salt" is the name of the type
// "Salt" is the name of salt's constructor

// makings stuff with the type
let a = Salt
let c:salt = Salt
let salts = [a;c; Salt]
let moarsalts:salt list = [a;c]

salts



// a function from salt is roughly as interesting as the type
let salty s = match s with
                  | Salt -> true

salty Salt
// What is the function salty a function from and to? Can you make it a function to an int or a string?

// Try to make something like this work
// let b = [Pepper; Pepper] 
// try to mix salt and pepper in a list and see what happens (it is supposed not to work)
