avarage a b = (a + b) / 2

main = do
    num <- getLine
    let x = read num::Float
    let arr = [1..25]
    let ans = minimum[abs((avarage a b) - x)| a<-arr, b<-arr]
    print(head ([[a, b] | a<-arr, b<-arr, (abs((avarage a b) - x) == ans)]))