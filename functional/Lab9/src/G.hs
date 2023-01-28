test t = t * t

tee :: (Int -> Int) -> Int -> Int
tee f t = f t

main  = do
    print(tee (test) 10)