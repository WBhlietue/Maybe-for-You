s :: Int -> Int -> [Int] -> Int
s first last a = do
    if first == last then
        a!!first
    else 
        a!!first + (s (first+1) last a)

main = do
    num <- getLine
    let n = read num :: Int
    num <- getLine 
    let m = read num :: Int
    let a =[1, 3, 5, 7, 9]
    let num = [x | x<-[n..m]]
    print(map (\x  -> (s x m a)) num)
    