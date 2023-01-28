nums = [2, 5, 7, 9, 13, 144, 8]

kv x = x * x
greater y =  filter (> 10) y
summ z =  foldr (+) 0 z

bodlogo1 = map(kv) nums
bodlogo2 = foldr (*) 1 nums
bodlogo3 = filter ( < 10) nums
bodlogo4 = (summ . greater) nums

main = do
    print (bodlogo1)
    print (bodlogo2)
    print (bodlogo3)
    print (bodlogo4)