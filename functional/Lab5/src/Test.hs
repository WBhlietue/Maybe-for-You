main = do
    x <- getLine
    let num = (read x :: Int)
    let d1 = num `div` 50
    let r1 = num `rem` 50

    let d2 = r1 `div` 20
    let r2 = r1 `rem` 20

    let d3 = r2 `div` 15
    let r3 = r2 `rem` 15

    let d4 = r3 `div` 10
    let r4 = r3 `rem` 10

    let d5 = r4 `div` 5
    let r5 = r4 `rem` 5

    let d6 = r5 `div` 3
    let r6 = r5 `rem` 3

    let d7 = r6 `div` 2
    let r7 = r6 `rem` 2

    let total = d1+d2+d3+d4+d5+d6+d7+r7
    print(total)


    