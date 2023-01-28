divs n = [x | x <- [1..n-1], n`rem`x == 0]
check n m = do
    m == sum (divs n) && n == sum (divs m)
main = do
    print([(x, y) | x <- [200..300], y<-[200..300] , check x y])
