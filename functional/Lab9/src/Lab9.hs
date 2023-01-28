-- 89a. evklidiin algorithm ahiglaj 2 toonii hieh g ol
-- 89b. evklidiin algorithm ahiglaj 2 toonii hbeh g ol

hieh a 0 = a 
hieh m n = hieh n (m`rem`n)

main = do 
    num <- getLine
    let m = read num :: Integer
    num <- getLine
    let n = read  num:: Integer
    let hi = hieh m n
    print("hieh: " ++ show hi)
    let hb = m * n `div` hi
    print("hbeh: " ++ show hb)
    