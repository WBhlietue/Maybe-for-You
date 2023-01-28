f 1 = 1

f n = n * f (n - 1)

main = do
    num <- getLine
    let n = read num :: Integer
    print (f n)
