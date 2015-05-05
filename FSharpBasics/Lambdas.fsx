// Basic inline lambda expression
let add = (fun x y -> x + y)

let result = add 2 2

// As with Functions, Lambdas can be passed in as Arguments into a Function
let twoTest test =
    test 2

twoTest (fun x -> x < 0)