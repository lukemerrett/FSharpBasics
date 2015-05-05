// A basic "Record" type declaration
type Book = 
  { Name: string;
    AuthorName: string;
    Rating: int;
    ISBN: string }

// Binding a new Book type instance
// Note how we haven't actually declared the type here; F# infers it based on the fields used
// Which is utterly nuts!
let expertFSharp = 
  { Name = "Expert F#";
    AuthorName = "Don Syme, Adam Granicz, Antonio Cisternino";
    Rating = 5;
    ISBN = "1590598504" }

// Accessing information inside the binding
printfn "I give this book %d stars out of 5!" expertFSharp.Rating

// Binding a type is also immutable; so the below would cause an error
// expertFSharp.AuthorName <- "Chris Marinos"

// There is however some awesome syntax for creating a new version of the same binding
// Preserving all the fields bar those you wish to override
let expertFSharpV2 = { expertFSharp with Name = "Expert F# 2.0" }

// The below shows how a nullable type can be declared using the "option" keyword
type Movie = 
  { Name: string;
    Director: string;
    Rating: int option; }

// To set the field to null you use the "None" option
let jurassicPark =
    {
        Name = "Jurassic Park";
        Director = "Steven Spielberg";
        Rating = None;
    }

// To set a nullable field to a value you use the "Some" keyword followed by the value
let et =
    {
        Name = "ET";
        Director = "Steven Spielberg";
        Rating = Some 4;
    }

// To set a nullable field to a value you use the "Some" keyword followed by the value
let indianaJones =
    {
        Name = "ET";
        Director = "Steven Spielberg";
        Rating = Some 5;
    }

// Below shows a switch/case statement
// "Some 5" matches an explicit value of 5
// "Some rating" matches any non-null value for the rating field
// "None" matches any null value for the rating field
let printRating movie =
    match movie.Rating with
    | Some 5 ->
      printfn "5 Star Rating?! Wow!"
    | Some rating -> 
      printfn "I give this movie %d star(s) out of 5!" rating
    | None -> printfn "I didn't review this book"

printRating jurassicPark
printRating et
printRating indianaJones