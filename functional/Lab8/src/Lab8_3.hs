-- p/q = m/n, (p q) hariltsan anhnii

isHariltsanAnhnii a b = do
    if a `mod` b == 0 then
        b
    else
        isHariltsanAnhnii b (a `mod` b)

checkNums a b c d = (a*d == b*c && (isHariltsanAnhnii c d) == 1)

main = do
    num1 <- getLine
    let m = read num1::Integer
    num2 <- getLine
    let n = read num2::Integer
    let list = [(a, b) | a <- [1..m-1], b <- [1..n-1] , (checkNums m n a b)]
    print(list)
    