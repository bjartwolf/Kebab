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

// Try to make something like this work
// let b = [Pepper; Pepper] 
// try to mix salt and pepper in a list and see what happens (it is supposed not to work)
