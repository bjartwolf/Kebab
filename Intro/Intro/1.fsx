// Mark the things you want to run and press CTRL+RETURN

// Defining a type in F#

type salt = Salt // must have capital letter

// makings stuff with the type
let a = Salt
let c:salt = Salt
let salts = [a;c]
let moarsalts:salt list = [a;c]

salts

// Try to make something like this work
// let b = [Pepper; Pepper] 