type ToCalculate = { Value1: float; Value2: float }

type Calculation =
| Add of ToCalculate
| Subtract of ToCalculate
| Multiply of ToCalculate
| Divide of ToCalculate

let calculate calculation =
    match calculation with
    | Add  toCalculate -> toCalculate.Value1 + toCalculate.Value2
    | Subtract toCalculate -> toCalculate.Value1 - toCalculate.Value2
    | Multiply toCalculate -> toCalculate.Value1 * toCalculate.Value2
    | Divide  toCalculate -> toCalculate.Value1 / toCalculate.Value2


let added = calculate (Add { Value1 = 2.00; Value2 = 3.00 })
let subtracted = calculate (Subtract { Value1 = 2.00; Value2 = 3.00 })
let multiplied = calculate (Multiply { Value1 = 2.00; Value2 = 3.00 })
let divided = calculate (Divide { Value1 = 2.00; Value2 = 3.00 })