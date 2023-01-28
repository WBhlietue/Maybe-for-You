strlen = do 
    print "Enter a string: "
    xs <- getLine
    putStr "The string has "
    putStr (show(length xs))
    putStrLn " characters"

main = strlen