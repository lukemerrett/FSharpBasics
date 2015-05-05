let rateEurToGbp = 0.73M
let rateUsdJpy = 79.428M

let convertCurrency rate value : decimal  = rate * value
let eurosToPounds eur = convertCurrency rateEurToGbp eur

let gbp = eurosToPounds 1000.0M
let jpy = convertCurrency rateUsdJpy 1000M

// F# allows you to define units of measure
// This allows a stronger association between types; eg ensuring a method only takes a decimal marked as GBP
[<Measure>]
type USD

[<Measure>]
type EUR

[<Measure>]
type GBP

[<Measure>]
type JPY

// By addding the attribute suffix we've told F# that this decimal is a GBP or EUR unit of measure
let rateEurGbp = 0.783M<GBP/EUR>

// This function will now only take a decimal marked as a EUR unit of measure
let euroToPounds (eur:decimal<EUR>) = eur * rateEurGbp

// We now must ensure the value we are passing in is of type "EUR"
let gbp = euroToPounds 1000.0M<EUR>

// The below will throw an exception, as the value provided is the wrong unit of measure
// let gbp2 = euroToPounds 1000.0M<USD>