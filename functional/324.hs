g a b | a == 0    = b
      | b == 0    = a
      | otherwise = g b (a`rem` b)

main = do
    num <- getLine
    let p = read num :: Integer
    num <- getLine
    let q = read num :: Integer
    let divs = [x | x<- [1..q], q`rem`x == 0]
    let ans = [x | x <- divs, g x p == 1]
    print(ans)