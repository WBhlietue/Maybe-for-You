b = [2, 5, 7, 9, 13, 144, 8, 10, 18, 196]

square n = n * n

s nums = foldr (+) 0 nums
greater nums = filter (>10) nums


main = do
    
    print (map (square) b)
    print (foldr (*) 1 b)
    print (filter (<10) b)
    print (s (greater b))
