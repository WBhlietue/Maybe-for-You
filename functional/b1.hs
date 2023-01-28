str = [2, 5, 7, 9, 13, 144, 8]

b1 = do
    let str2 = filter even str;
    let l = length str2
    if l > 0
        then
            print("baina")
        else
            print("baihgu")  

b2 = do
    print(str)
main = do
    b1
    b2