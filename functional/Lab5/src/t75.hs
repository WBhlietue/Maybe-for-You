check a b c = (a*3 + b*5 )  == c

main = do
    num <- getLine;
    let n = read num::Int
    let arr = [(x, y) | x <- [0..n], y <- [0..n], check x y n]
    print(arr)