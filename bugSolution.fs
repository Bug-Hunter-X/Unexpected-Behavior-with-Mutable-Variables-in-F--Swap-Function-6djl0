let x = 10
let y = 20

let swap (x, y) = 
    (y, x)

let x', y' = swap (x, y)
printf "%d %d" x' y' // Output: 20 10

//Alternative solution
let swap2 x y = 
    y, x
let x2, y2 = swap2 x y
printf "%d %d" x2 y2