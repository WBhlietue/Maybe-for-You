main = do
    let list = [1..17]
    let sets = [abs(list !! (i - 1) - list !! (j - 1)) | i <- [1..17], j <- [i..17]]
    print(foldr (+) 0 sets)