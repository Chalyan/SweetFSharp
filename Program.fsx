open System.Runtime.CompilerServices

printfn "%s" "-----"
let mutable x = 2
printfn "%d" x
x <- 3
printfn "%d" x

let add y z = y + z
let increment = add 1
printfn "%d" (increment 4)
printfn "%s" "-----"

let super_increment (x:byref<'int>) : unit =
    x <- x + 1

let super_duper_increment_demonstration =
    let mutable y = 13
    super_increment &y
    printfn "%d" y

super_duper_increment_demonstration
