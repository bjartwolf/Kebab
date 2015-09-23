
exception Nope
let wa _ = raise Nope
let t = ()

(*
    invalidPositions should compare two (x, y)-tuples with positions for two queens
    and return true if they are attacking each other

    validSolution takes a (queen, board)-tuple as arguments
        the queen is an (x, y)-tuple with the position of a queen
        the board is a list of (x, y)-tuples for already positioned queens
    it should return true if it is fine to add the queen to the board
    (if the new queen is not attacking any of the queens already positioned)


    newBoards takes a y and a board as arguments
        the y is a column number, an int
        the board is a list of (x, y)-tuples positioned queens
    it should:
        make new boards by adding queens to different rows in the y column
            (i.e. by making new (x, y)-tuples for possible positions for the new queen)
        and return the new boards that do not have any queens attacking each other
*)

let queens n =
    let invalidPosition (x1, y1) (x2, y2) = (wa t) // todo
    let validSolution (queen, board) = not (Seq.exists (invalidPosition queen) board)

    let newBoards y board : (int * int) list seq = (wa t) // todo

    let allNewBoards boards y = Seq.collect (newBoards y) boards
    Seq.fold allNewBoards (Seq.singleton []) (seq { 1 .. n })

queens 4

Seq.length (queens 8)
