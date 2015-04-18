type kebab = Skewer | Onion of kebab | Lamb of kebab | Tomato of kebab

let rec getRidOfOnions kebab =
    match kebab with 
        | Skewer -> Skewer
        | Onion x -> getRidOfOnions x
        | Lamb x -> Lamb (getRidOfOnions x)
        | Tomato x -> Tomato (getRidOfOnions x)

getRidOfOnions (Onion (Lamb (Onion (Skewer))))

// Lage noe som legger tomater over løk istedenfor. Eller bytter ut Lamb med Tomater

// Lag noe som teller tomater - en funksjon fra kebab til int

// active patters - bruk denne til å matche på..!
let (|Vegetable|Meat|Thing|) input = 
        match input with 
                | Onion x -> Vegetable x
                | Lamb x-> Meat x
                | Skewer -> Thing
                | Tomato x-> Vegetable x

