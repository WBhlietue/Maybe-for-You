f 1 = 1
f 2 = 1
f 3 = 1
f x = (f (x-1)) + (f (x-3))

p 1 = 2
p n = 2 * (p (n - 1))

main =  do
    let arr = [1..100]
    let ans = foldr (+) 0 (map(\x -> ((f x) / (p x))) arr)
    print(ans)