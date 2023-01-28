loop :: Integer -> Integer -> Integer -> Integer -> [String]
loop kNum total l k = do
    if kNum * k > total then
        return "cannot"
    else do
        if (total - kNum * k ) `rem` l == 0 then 
            return ((show k) ++ "*" ++ (show kNum) ++ "+" ++ (show l) ++ "*" ++ (show ((total - kNum * k ) `div` l)) ++ "=" ++ (show total))
        else 
            loop (kNum + 1) total l k

main = do
    num1 <- getLine
    let k = read num1 :: Integer
    num2 <- getLine
    let l = read num2 :: Integer
    numl <- getLine
    let m = read numl :: Integer
    print(loop 0 m k l)