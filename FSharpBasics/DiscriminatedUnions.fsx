// Discriminated Unions are effectively Enums but more awesome

// Standard "Enum" style Discriminated Union
type MushroomColor =
| Red
| Green
| Purple

// Note how we can link this Union to another type
type PowerUp =
| FireFlower
| Mushroom of MushroomColor
| Star of int

let handlePowerUp powerUp =
    match powerUp with
    | FireFlower -> printfn "Ouch, that's hot!"
    | Mushroom color -> match color with
                        | Red -> printfn "Please don't step on me..."
                        | Green -> printfn "1UP!!!"
                        | Purple -> printfn "Sorry, about that!"
    | Star duration -> printfn "Let me play some special music for you 
        for %d seconds." duration

let fireflowerPowerup = FireFlower
let mushroomPowerup = Mushroom Red
let starPowerup = Star 14

handlePowerUp fireflowerPowerup
handlePowerUp mushroomPowerup
handlePowerUp starPowerup

// Discriminating Unions can even be used against Record Types.
type Person = {
    FirstName: string;
    LastName: string;
}

type Role =
| Admin of Person
| User of Person
| Guest of Person

let siteAdmin = Admin {FirstName = "Jim"; LastName = "Smith"}
let siteUser = User {FirstName = "Jane"; LastName = "Jones"}
let siteGuest = Guest {FirstName = "Jon"; LastName = "Smart"}