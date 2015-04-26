type seasoning = Salt | Pepper

// Meat is not food without seasoning. Carrots is not food without a number of them.
type food = Meat of seasoning
          | Carrots of int
          | SeaWater

Meat
Carrots
Meat Pepper
Carrots 2

// functions from types with things with things can match with things within things

let salty f = match f with
                  | Meat Salt -> true
                  | Meat Pepper -> false
                  | Carrots _ -> true
                  | SeaWater -> true

salty (Carrots 2)

// Potato chips is also salty food. Add some.
// Or maybe make some SeasonedCarrots - if you season them with salt they are probably salty too...