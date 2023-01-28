main = do
    num <- getLine
    let n = read num::Integer
    let list = [[x, y, z, r] | x <- [1..n],y <- [1..x], z <- [1..y], r <- [1..z], (x*x + y*y + z*z + r*r == n)]
    print(list)