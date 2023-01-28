f 1 = 1
f n = n * f (n - 1)

getNum k x = (1 + sin (k * x) / f k)


main = do
    num1 <- getLine
    let x = read num1 :: Float
    num2 <- getLine
    let nt = read num2 :: Integer
    let n = fromInteger nt :: Float
    print (foldr (+) 0 [getNum k x | k <- [1..n]])
