// alt + enter to send line or selection to fsi/repl
// Reset fsi by clicking on "Kill Terminal" (the garbage can icon) in the VS Code terminal


// (couple of types)

type meza =
  | Shrimp
  | Calamari
  | Escargots
  | Hummus
   
type main =
  | Steak
  | Ravioli
  | Chicken
  | Eggplant

// some values
Shrimp
Steak
(Shrimp, Steak)
(Steak, Steak, Steak)

// (couple more types)
type salad =
  | Green
  | Cucumber
  | Greek

type dessert =
  | Sundae 
  | Mousse
  | Torte

// type with stars :)
type dinner =
  | ThreeCourse of (meza * main * dessert)
  | FourCourse of (meza * salad * main * dessert)
// (you can read * as "and":
// "type dinner is ThreeCourse of meza and main and dessert,
//              or FourCourse of meza and salad and main and desert")

let aDinner = FourCourse (Escargots, Green, Steak, Mousse)
let anotherDinner = ThreeCourse  (Shrimp, Ravioli, Torte)

let vegetarian (d : dinner) : dinner =
  match d with
  | ThreeCourse (me, Steak, de) -> ThreeCourse (me, Eggplant, de)
  | ThreeCourse (me, Chicken, de) -> ThreeCourse (me, Eggplant, de)
  | ThreeCourse (me, ma, de) -> ThreeCourse (me, ma, de)
  | FourCourse (me, sa, Steak, de) -> FourCourse (me, sa, Eggplant, de)
  | FourCourse (me, sa, Chicken, de) -> FourCourse (me, sa, Eggplant, de)
  | FourCourse (me, sa, ma, de) -> FourCourse (me, sa, ma, de)

vegetarian aDinner

vegetarian anotherDinner

// Can we shorten the vegetarian function?
// Do we need to match that many patterns?
// Can we use a helper function?
// Who mistook the steak for chiecken?
