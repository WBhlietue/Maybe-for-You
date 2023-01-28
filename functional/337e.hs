import Data.List

e = 2.71828182846


getNum i  = -1 + (i / 40) * 4

y x = x*x*e ** (-1* (abs(x)))

printGraphic num = do
    -- let num = read (show num) :: Int
    putStr (foldr (++) "" (take num (repeat "  ")))
    putStr  "*"
    putStr  (foldr (++) "" (take (40-num) (repeat "  ")))
    putStr "\n";
    
printAns (x:[])  = printGraphic (round(last ( x))) 
printAns (x:xs)  = do
    printGraphic (round (last ( x))) 
    printAns(xs)


main = do
    let list = [[y (getNum (x)),  x]| x <- [0..40]]
    let l = (sort list)
    print("!23")
    printAns l
