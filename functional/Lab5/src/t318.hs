f::Float -> Float
f i = do
    let arr = [ 1/(i*i + x + 1) | x<-[0..i]]
    foldr (+) 0 arr

main = do
    num <- getLine
    let n = read num :: Float
    let arr = [(f x) | x<-[0..n]]
    print(foldr (*) 1 arr)


