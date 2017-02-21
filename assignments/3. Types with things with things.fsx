// alt + enter to send line or selection to fsi/repl
// Reset fsi by clicking on "Kill Terminal" (the garbage can icon) in the VS Code terminal


type seasoning = Salt | Pepper

// Meat is not food without seasoning. Carrots is not food without a number of them.
type food = Meat of seasoning
          | Carrots of int
          | SeaWater
// Meat, Carrots and SeaWater are food's constructors
// Meat needs an argument of seasoning to construct a value of type food
// Carrots needs an argument of int to construct a value of type food

Meat
Carrots
Meat Pepper
Carrots 2

// functions from types with things with things can match with things within things

let salty f = match f with
                  | Meat Salt -> true
                  | Meat Pepper -> false
                  | Carrots _ -> false
                  | SeaWater -> true

salty (Carrots 2)

// Potato chips is also salty food. Add some.
// Or maybe make some SeasonedCarrots - if you season them with salt they are probably salty too...