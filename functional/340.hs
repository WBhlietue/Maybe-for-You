main = do
    let list= [1..20]
    num <- getLine
    let n = read num :: Integer
    print([(x, y, z) | x<-list, y<-list, z<-list, (x+y+z == n)])