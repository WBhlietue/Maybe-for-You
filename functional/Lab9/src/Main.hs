andd :: [Bool] -> Bool
andd [] = True
andd (x:xs) = do
   if (x) then
      andd xs
    else 
      False

orr :: [Bool] -> Bool
orr [] = False
orr(x:xs) = do
    if(x) then
      True
    else
      orr xs

merge ::[[Integer]] -> [Integer]
merge [] = []
merge (x:xs) = x ++ merge xs

main = do
  print (andd [True, True, True, True])
  print (orr [False, False, False, False])
  print (merge [[1, 2], [3, 5, 6], [1, 6, 3]])