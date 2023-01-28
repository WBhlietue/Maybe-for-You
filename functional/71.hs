f a = a*a*a-2.25*a

check n | n < 0                     = check (n+1.5)
        | n > 1.5                   = check (n-1.5)
        | otherwise                 = n

main = do
    num <- getLine 
    let a = read num :: Float
    print(f (check a))