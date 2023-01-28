doNum num = do
    if num `mod` 2 == 0
        then do
            print(num)
        else  return()

test s t = do
    let num = t - s + 1
    if s > 1
        then do 
            doNum num
            test (s - 1) t
        else
            doNum num
            
startNumsFor num = test num num

anhniiToonHuvaagch num huv = do
    if num == 1 
        then return()
        else do
            if num `mod` huv == 0
                then do
                    print(huv)
                    anhniiToonHuvaagch (num `div` huv) huv
                else do 
                    anhniiToonHuvaagch num ( huv + 1) 
    

main = do
    anhniiToonHuvaagch 100 2