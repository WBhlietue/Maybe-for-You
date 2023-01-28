sm i j = 1 / (i * i  + j)

loopSum i j = do
    if j == i + 1 then 
         (sm i j)
    else 
         ((sm i j) + (loopSum i (j + 1)))

loop :: Float -> Float -> Float
loop i n = do
    if i == n then
        loopSum i 1
    else 
       ( (loopSum i 1) * (loop (i+1) n))

main = do
    num <- getLine
    let n = read num :: Integer
    -- print(loop 1 8)
    print(loop 1 (fromInteger n))
    print("hi")