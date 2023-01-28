-- Hurd

get::[Integer] -> String
get x = do
    ((show( x!!0)) ++ "X" ++ (show (x!!1)) ++ "=" ++ (show(x!!0 * x!!1)))

main = do
    let arr = [[x, y] | x<- [1..9], y <- [1..9]]
    print( map (get) arr)