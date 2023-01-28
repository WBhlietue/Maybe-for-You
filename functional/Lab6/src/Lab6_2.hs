main=do
    print "Enter a number n="
    xs <- getLine
    let n=(read xs :: Integer )
    putStr " The N nuber has "
    putStr (show n)