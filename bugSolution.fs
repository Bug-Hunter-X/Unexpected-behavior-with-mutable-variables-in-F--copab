let x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y // Output: 10 11

let x2 = addOne x
printfn "%d %d" x x2 // Output: 10 11