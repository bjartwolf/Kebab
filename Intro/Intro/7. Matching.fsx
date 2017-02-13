// alt + enter to send line or selection to fsi/repl
// Reset fsi by clicking on "Kill Terminal" (the garbage can icon) in the VS Code terminal


type kebab = Skewer | Onion of kebab | Lamb of kebab | Tomato of kebab

let rec getRidOfOnions kebab =
    match kebab with 
        | Skewer -> Skewer
        | Onion x -> getRidOfOnions x
        | Lamb x -> Lamb (getRidOfOnions x)
        | Tomato x -> Tomato (getRidOfOnions x)

getRidOfOnions (Onion (Lamb (Onion (Skewer))))

// Make a function that puts tomatoes on top of onsions instead. Or replaces Lamb with Tomato.

// Make a function that counts tomatoes -- a function from kebab to int

// active patterns
let (|Vegetable|Meat|Thing|) input = 
        match input with 
                | Onion x -> Vegetable x
                | Lamb x-> Meat x
                | Skewer -> Thing
                | Tomato x-> Vegetable x

// make a function isVeg from kebab to bool that checks is things are vegetarian matching on the Vegetable, Things and Meat
// see if you can add some more types of vegetables to the kebab - without changing your isVeg function?

