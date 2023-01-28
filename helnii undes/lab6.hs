strings = ["Neg", "Hoyor", "Gurvan", "Durvun"]

addShagai str = str ++ " shagai"

answer = map(addShagai) strings

main = print(answer)