-- 79, (1+sin0.1)(1+sin0.2)...(1+sin n) = ?

gMap :: (Float -> Float) -> [Float] ->[Float]
gMap f (x:[]) =[ f x]
gMap f (x:xs) = [(f x)] ++ (gMap f xs)

gFoldr::(Float -> Float -> Float) -> Float -> [Float] -> Float
gFoldr f i (x:[]) = (f i x)
gFoldr f i (x:xs) = gFoldr f (f i x) xs

main = do
    num <- getLine
    let n = read num :: Float
    let arr = gMap (\x -> 1 + sin (x / 10))  [1..n * 10];
    let ans = gFoldr (*) 1 arr
    print(ans)
