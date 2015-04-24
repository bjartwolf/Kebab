// By separating things with | we can make more things in a type

type seasoning = Salt | Pepper
let seasonings = [Salt ; Pepper ; Pepper; Salt]
seasonings

// functions from types of multiple thing should match with multiple things...
let salty s = match s with
                  | Salt -> true
                  | Pepper -> false

// Try making something with three or four different things
