fuct 1 = 1
fuct x = x * fuct(x-1)



main = do
    num <- getLine;
    let x = read num :: Float
    let list1 = [3, 7, 11]
    let list2 = [5, 9, 13]
    let l1 = [(x ** a / (fuct a)) | a<-list1]
    let l2 = [(x ** a / (fuct a)) | a<-list2]
    print(x - (foldr(+) 0 l1) + (foldr(+) 0 l2))