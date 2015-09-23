exception Nope
let wa _ = raise Nope
let t = ()

type seasoning = Salt | Pepper

// to/from string:

let seasoningToString s =
    match s with
    | Salt -> "Salt"
    // todo

printfn "%A" (seasoningToString Salt)

let stringToSeasoning s : string =
    match s with
    // todo
    | _ -> raise Nope

stringToSeasoning "Salt"

let slist = [Salt; Salt; Pepper; Salt]




// list to/from string:

let rec serializedSeasoning slist =
    match slist with
    | hd :: tl -> seasoningToString hd + serializedSeasoning tl
    | [] -> ""

serializedSeasoning slist

let deserializedSeasoning s : seasoning list =
    let rec halp s =
        match s with
        // todo
        | [] -> []
        | _ -> raise Nope
    halp (Seq.toList s)

deserializedSeasoning "SaltSaltPepperSalt"

// runlengthy:

let countAndRest element lst =
    let rec halp count lst =
        match lst with
            | hd :: tl -> if hd = element
                          then halp (count + 1) tl
                          else ((count, element), hd :: tl)
            | [] -> ((count, element), [])
    halp 0 lst

countAndRest Salt [Salt; Salt; Pepper; Salt]

let rec counts lst =
    match lst with
        | hd :: tl -> let (count, rest) = countAndRest hd (hd :: tl)
                      count :: counts rest
        | [] -> []

counts [Salt; Salt; Pepper; Salt]

let encode lst =
    let rec halp lst =
        match lst with
            | (count, s) :: tl -> string count + seasoningToString s + halp tl
            | [] -> ""
    halp (counts lst)

encode [Salt; Salt; Pepper; Salt]

let implode (charList : char list) = System.String.Concat(Array.ofList(charList))
let explode = Seq.toList
let isDigit c =  System.Char.IsDigit(c)
let rec repeat element num = if num > 0 then element :: repeat element (num - 1) else []

let readNumber clist =
    let num = System.Int32.Parse(implode (List.ofSeq (Seq.takeWhile isDigit clist)))
    let rest = List.ofSeq (Seq.skipWhile isDigit clist)
    (num, rest)

let decode str : seasoning list =
    let rec halp clist =
        match clist with
            | [] -> []
            | clist -> (wa t) // todo
    halp (explode str)

decode "2Salt3Pepper10Salt"

