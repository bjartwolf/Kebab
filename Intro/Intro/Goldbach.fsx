exception Nope
let wa _ = raise Nope
let t = ()

(* Goldbach's conjecture (https://en.wikipedia.org/wiki/Goldbach%27s_conjecture) states that every
even integer greater than 2 can be expressed as the sum of two primes.

The goldback function below takes an integer n and returns a tuple (p1, p2) of two primes where p1 + p2 = n.

What should happen if 1, 2 or an odd number is given as argument for the function?

isPrime takes a number and determines if it is a prime or not.

findPrimeTuple takes a number d, and returns the tuple (d, n-d) if both the numbers are primes, otherwise it calls itself with another d *)

let goldbach n : int * int = 
    let isPrime n : bool = wa t
    let rec findPrimeTuple d  : int * int = wa t
    findPrimeTuple 2

goldbach 28

goldbach 35
