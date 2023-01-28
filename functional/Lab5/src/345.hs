loop :: Int -> [Int] -> Int
loop n arr = do
    if n == ((length arr) - 1) then 
        arr!!0 * arr!!((length arr) - 1)
    else do
        let a = (length arr)-1-n
        let a1 =arr!!n * arr!!a
        let a2 =(loop (n+1) arr)
        a1+a2

getNum :: Int -> [Int] -> Int
getNum n arr = do  
    if (length arr) == n then 
         arr !! ((length arr) - 1)
    else do
        let a = loop 0 arr
        let b = arr ++ [a]
        getNum n b

main = do
    let arr = [1]
    -- num <- getLine
    -- let n = read num :: Int

    let n = 10
    let a = getNum n arr
    print(a)