// alt + enter to send line or selection to fsi/repl
// Reset fsi by clicking on "Kill Terminal" (the garbage can icon) in the VS Code terminal

// e.g. put cursor on line below and alt + enter
String.length "Hello"

// expressions evaluate to values. the expression above evaluates to the value 5
// the expression is a function application, and goes like <function> <argument>
// (String.length is the function, "Hello" is the argument)

// define a variable with let <name> = <expression>
let x = 2

let y = x + x

// most nice things are values...

// some values are numbers
2
5 + 3
5 + y

// some values are strings
"Hello"
String.replicate 4 "hello"

// some values are booleans
true
false
4 < 7
true && false

// and some values are functions
fun x -> x + x

// variables can hold functions
let foo = fun x -> x + x

// and functions can be applied to arguments
foo 4
(fun x -> x + x) 4

// there's a shorthand syntax for defining functions with let
// it goes something kind of like
// let <name> <arg> ... = <expression>
// (foo and foo2 are "the same" function)

let foo2 x = x + x
foo2 4

// multiple arguments via function that returns function
// (bar, bar2 and bar3 are "the same" function)

let bar = fun x -> fun y -> x + y * 2
let bar2 = fun x y -> x + y * 2
let bar3 x y = x + y * 2 

bar 5 6

// if we wanna more stuff we hafta care about indentation a little

let quux x =
  let y = x + x
  let z = y * y
  y + z

quux 3

// we get types for more interesting values by combining the types of less interesting ones

// tuples, or products
// the , (in the expression) can be read as "and"
// the * (in the type) can also be read as "and"
let aTuple = (2, "hello")

// we pattern match do deal with the more interesting types
let glorp x =
  match x with
    | (num, str) -> String.replicate num str

glorp aTuple
glorp (3, "hi")

// discriminated unions, or tagged unions, or sums
// (we can read | as "or")
type Shape
  = Square of float
  | Rectangle of float * float
  | Circle of float

let aShape = Square 5.0
let anotherShape = Rectangle (3.2, 7.0)
let aThirdShape = Circle 4.7

// pattern matching on discriminated unions lets us case analysis
let area x =
  match x with
    | Square side -> side * side
    | Rectangle (width, height) -> width * height
    | Circle radius -> radius * System.Math.PI * System.Math.PI

area aShape
area anotherShape
area aThirdShape

