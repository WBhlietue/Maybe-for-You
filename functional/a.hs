nums 1 = 1
nums i = nums(i - 1) + (1/i)

check i num = do
    if((nums i ) > num) then
        nums i
    else
        check (i+1) num

main = do
    num <- getLine
    let n = read num :: Float
    print(check 1 n)
