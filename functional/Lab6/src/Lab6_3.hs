search i j x arr = do
    let m = (i + j) `div` 2
    if x == arr !! m then
        m
    else 
        if (x < arr!!m && i < m) then
            search i (m - 1) x arr
        else
            if(x > arr!!m && j > m) then
                search (m+1) j x arr
            else
                -1

check x |x < 0            = "negative"
        |x `rem` 2 == 0   = "even"
        |otherwise        = "odd"

main =  do
    let arr = [x^2 | x <- [1..45], even x]
    print( "arr = " ++ (show arr))
    num <- getLine
    

    let n = read num::Integer
    if n`elem`arr then
        putStrLn("i = " ++ show(search 0 ((length arr) - 1) n arr))
    else
        print("-1")

    num2 <- getLine
    
    let x = read num2::Integer
    print(check x)