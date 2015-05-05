let basicBindings =
    let lucky = 3 + 4
    let unlucky = lucky + 6
    unlucky

basicBindings

let duplicated = "original value"
// Fires this error "Duplicate definition of value 'duplicated'"
// This is because all "let" bindings in F# are immutable by default.
let duplicated = "new value" 

// Binding using the mutable keyboard means we can reassign the value
let mutable modifiable = "original value"
modifiable <- "new value"

// F# is a statically typed language (unlike Python or Ruby)
// However it has a powerful type inference system to improve brevity
// Running this in the REPL will give you 3 values with the types int, float and string.
let anInt = 10
let aFloat = 20.0
let aString = "I'm a string!"

let printBasics message number = 
    printfn message
    printfn "The answer is %d" number

printBasics "Hello world!" 42
