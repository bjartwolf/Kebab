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

let mealone = (Hummus, Eggplant, Torte) // Hva er min type?
let mealtwo = (Hummus, Steak,  Torte) // og min?
let mealthree = (Sundae, Steak, Torte) // og min?
//type meal = meza * main * dessert
let hassteak meal = match meal with
                        | (_,Steak,_) -> true
                        | _           -> false

// lage en funksjon som bytter ut alt med kjøtt slik at
// replaceMainWithSteak mealone = mealtwo
  
