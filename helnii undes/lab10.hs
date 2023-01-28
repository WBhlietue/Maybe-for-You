b = [1]
lp s e ar = do
    print("b[" ++ (show s) ++ "] = ")
    input <- getLine
    let n = (read input :: Int)
    if s == e then do
        print(foldr (*) 1 (ad n ar))
    else do
        lp (s + 1) e (ad n ar)

ad num arr = arr ++ [num]

main = do
    print("input massiv item's number n = ")
    input <- getLine
    let n = (read input :: Int)
    lp 0 n b