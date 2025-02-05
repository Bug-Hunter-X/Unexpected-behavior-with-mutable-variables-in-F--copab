let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y // Output: 10 11
x <- addOne x
printfn "%d %d" x y // Output: 11 11