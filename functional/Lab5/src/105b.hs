main = do
    num1 <- getLine
    let x = read num1 :: Float
    num2 <- getLine
    let nt = read num2 :: Integer
    let n = fromInteger nt :: Float

    let a1 = x ** (n ** 3)
    let b = a1 / ( 3 ** n)

    print(b)
