main = do
    print(foldr (+) 0 [1/(4**x + 25 * 5**x) | x <- [0..100000]])