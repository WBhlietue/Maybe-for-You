check num huv  = do
    if num == 1 
        then do
            if huv > 5 then do
                0
            else do
                1
        else do
            if num `mod` huv == 0
                then do
                    check (num `div` huv) huv
                else do 
                    check num ( huv + 1) 

loop i num = do
    if num == 0 then
        return()
    else do
        if check i 2 == 1 
            then do
                print(i)
                loop (i + 1) (num - 1)
            else
                loop (i + 1) num

main = do
    n <- getLine
    let x = read n :: Int
    putStrLn ("---")
    loop 2 x