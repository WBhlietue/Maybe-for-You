import System.TimeIt
import System.Random

b = [1]
lp s e ar = do
    let n = s
    if s == e then do
        ad n ar
    else do
        lp (s + 1) e (ad n ar) 


main = do
    -- let arr = lp 0 10000 b
    -- let arrOdd = filter odd arr;
    -- let arrEven = filter even arr;
    -- print $ map(kv) arr
