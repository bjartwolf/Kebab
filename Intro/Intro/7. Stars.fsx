type meza =
        Shrimp
        | Calamari
        | Escargots
        | Hummus
   
type main =
        Steak
        | Ravioli
        | Chicken
        | Eggplant

type salad =
        Green
        | Cucumber
        | Greek

type dessert = 
        Sundae 
        | Mousse
        | Torte

let mealone = (Hummus, Eggplant, Torte) // What is my type?
let mealtwo = (Hummus, Steak,  Torte) // and my?
let mealthree = (Sundae, Steak, Torte) // and my?
//type meal = meza * main * dessert
let hassteak meal = match meal with
                        | (_,Steak,_) -> true
                        | _           -> false

// make a function that replaces any main with a Steak, so that
// replaceMainWithSteak mealone = mealtwo
