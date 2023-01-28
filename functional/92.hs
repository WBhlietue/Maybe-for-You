u 1 = 0
u 2 = 0
u 3 = 1.5
u i = (i + 1) / (i * i + 1) * (u ( i - 1)) - (u (i-2)) * (u (i-3))

main = do
    num <- getLine
    let n = read num :: Float
    print(u n)