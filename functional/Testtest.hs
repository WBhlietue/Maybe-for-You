canD num x = num `rem` x == 0

isP num = length [(x)| x<- [2..num-1], canD num x] == 0

main = do
    let num = [(x) | x <- [2..1000], isP x]
    print (num)
