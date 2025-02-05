# Unexpected Behavior with Mutable Variables in F#

This example demonstrates a common pitfall when working with mutable variables in F#.  Due to F#'s use of references, changes within a function can impact the variable outside of it.

## The Bug
The `addOne` function seemingly only adds one to its argument; however, because `x` is mutable and passed by reference, the original `x` is altered directly, leading to unexpected outputs.  The original value (10) is increased within `addOne` and in the next `printfn` call. 

## The Solution
The solution involves understanding how F# handles mutability. If the intention is to avoid affecting the original variable, the function should create a copy (effectively passing by value). This makes the changes within the function isolated and prevents side effects on the original value.
