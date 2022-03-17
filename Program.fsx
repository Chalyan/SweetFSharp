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

let super_increment (x:int byref) : unit =
    x <- x + 1

let super_duper_increment_demonstration =
    let mutable y = 13
    super_increment &y
    printfn "%d" y

super_duper_increment_demonstration

type Employee(id: int, name: string) = 
    let mutable empId = id
    let mutable empName = name

    member instance.print =
        printfn "%d%s%s" empId " " empName

let emp = Employee(1,"Gor")
emp.print

type Car() as cr = 
    class
        let mutable myInt: int = 10
        member this.addNumbers(x: int, y: int): int = 
            x + y
        member this.incrementmyInt(): unit =
            myInt <- cr.addNumbers(myInt,1)
        member this.get(): int =
            myInt
        member this.set(settledInt: int): unit =
            myInt <- settledInt
    end

let car = new Car()
car.set(0)
car.incrementmyInt()
printfn "%d" (car.get())

let mutable carArr: Car array = Array.zeroCreate 3
let a = Car()
a.set(1)
let b = Car()
b.set(2)
let c = Car()
c.set(3)

carArr.[0] <- a
carArr.[1] <- b
carArr.[2] <- c

for i in 0..2 do
    printfn "%d" (carArr.[i].get())
