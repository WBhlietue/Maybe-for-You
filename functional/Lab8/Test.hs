list1 = [6, 0, 2, -4, 15, 9, -22, 24]
list2 = [15, 3, 5, -7, 51, 39, 60, -52]
list3 = [24, 6, 8, -10, 87, 69, -82,  96]

m = 56

main = do
    let l1 = [(x, y, z) | x <- list1, y <- list2, z <- list3 , x + y + z == m]
    let l2 = [(x, y, z) | x <- list1, y <- list2, z <- list3 , x + y - z == m]
    let l3 = [(x, y, z) | x <- list1, y <- list2, z <- list3 , x - y + z == m]
    let l4 = [(x, y, z) | x <- list1, y <- list2, z <- list3 , x - y - z == m]
    
    print(l1)
    print(l2)
    print(l3)
    print(l4)
    