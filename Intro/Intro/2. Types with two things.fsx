// ctrl+enter to send line or selection to fsi/repl
// reset fsi by rightcliking in the F# Interactive and click reset


// By separating things with | we can make types of with more things

type seasoning = Salt | Pepper
// Salt and Pepper are the seasoning's constructors
// (you can read | as "or" if you wanna: "type seaoning is Salt or Pepper")

let seasonings = [Salt ; Pepper ; Pepper; Salt]
seasonings

// functions from types of multiple thing should match with multiple things...
let salty s = match s with
                  | Salt -> true
                  | Pepper -> false

// Try making something with three or four different things
