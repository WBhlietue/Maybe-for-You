loop :: Integer -> Integer -> [String]

loop five total = do
    if five * 5 > total then
        return "cannot"
    else do
        if (total - five * 5 ) `rem` 3 == 0 then 
            return ((show five) ++ "*5+" ++ (show ((total - five * 5 ) `div` 3)) ++ "*3=" ++ (show total))
        else 
            loop (five + 1) total

main = do
    num <- getLine
    let n = read num :: Integer

    print(loop 0 n)
