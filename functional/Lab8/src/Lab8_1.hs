-- a(a+1)(a+2)...(a+n-1)

main = do
    num1 <- getLine
    let a = read num1::Integer
    num2<- getLine
    let n = read num2::Integer 
    let arr = [(a + x-1) | x <- [1 .. n]]

    print(foldr(*) 1 arr)