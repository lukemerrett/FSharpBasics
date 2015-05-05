// This will error has F# doesn't know "phrase" is a string type
let toHackerTalk phrase =
    phrase.Replace('t', '7').Replace('o', '0')

// This will work just fine as we've told the function what type "phrase" is
let toHackerTalk (phrase:string) =
    phrase.Replace('t', '7').Replace('o', '0')

toHackerTalk "Leet Talk Is Cool"

// Functions can be passed in as Values
let quadruple x =    
    let double x =
        x * 2

    double(double(x))

let result = quadruple 24

// Functions can even be passed in as Arguments to another Function
let chrisTest test =
    test "Chris"

let isMe x =
    if x = "Chris" then
        "it is Chris!"
    else
        "it's someone else"

let isItChris = chrisTest isMe