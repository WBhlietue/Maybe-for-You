minNum a b = do
    if(a < b) then 
        a
    else
        b

main = do
    num1 <- getLine
    let a = read num1 :: Float
    num2 <- getLine
    let b = read num2 :: Float
    print (minNum a b)
