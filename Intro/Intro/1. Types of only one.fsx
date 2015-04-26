// Mark the things you want to run and press CTRL+RETURN

// Defining a type in F#

type salt = Salt // must have capital letter

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
