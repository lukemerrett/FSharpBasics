// We need this reference to run F# in interactive mode
#r @"..\packages\FSharp.Data.2.2.1\lib\net40\FSharp.Data.dll"
open FSharp.Data

// This lovely bit of code creates a new type based on the headers and data in the file provided!
// No modelling required
// You can also point this to a local CSV sample assuming it has the same headers and sample data
// This would save the round trip to the server
type Stocks = CsvProvider<"http://ichart.finance.yahoo.com/table.csv?s=MSFT">

let msft = Stocks.Load("http://ichart.finance.yahoo.com/table.csv?s=MSFT")

// Look at the most recent row. Note the 'Date' property
// is of type 'DateTime' and 'Open' has a type 'decimal'
let firstRow = msft.Rows |> Seq.head
let lastDate = firstRow.Date
let lastOpen = firstRow.Open

// Print the prices in the HLOC format
for row in msft.Rows do
  printfn "HLOC: (%A, %A, %A, %A)" row.High row.Low row.Open row.Close