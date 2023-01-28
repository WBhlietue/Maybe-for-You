module Main (main) where

e = 2.718281828459045

main = do
    num1 <- getLine
    let x = (read num1 :: Float)
    num2 <- getLine
    let y = (read num2 :: Float)
    num3 <- getLine
    let z = (read num3 :: Float)

    let a = (3 + e ** (y - 1)) / (1 + x * x * (abs (y - (tan z))))
    print (a)

    let b = 1 + (abs y - x) + ((y - x) ** 2) / 2 + (abs (y - x) ** 3) / 3
    print (b) 
    