main = do
    num <- getLine
    let n = read num :: Integer
    let arr = [(x1, x2, x3, x4, x5) | x1 <- [1..n], x2 <- [1..x1], x3 <- [1..x2], x4 <- [1..x3], x5 <- [1..x4], (x1+x2+x3+x4+x5 == n)]
    print(arr)