fact :: Int -> Int
fact 1 = 1
fact n = n * fact (n-1)

main = do
    num <- getLine
    let n = read num ::Int
    print(fact n)