
loop :: Float -> Float 
loop num = do
    if num == 1 then
        2
    else
        (1 + 1 / num / num) * (loop (num-1))

main = do
    num <- getLine
    let n = read num::Float
    let a = loop n
    print (a)