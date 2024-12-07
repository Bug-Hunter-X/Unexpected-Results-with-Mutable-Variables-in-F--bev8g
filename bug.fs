let mutable x = 10
let mutable y = 20

let add x y =  x + y

printf "%d" (add x y)

x <- 15
y <- 25

printf "%d" (add x y)