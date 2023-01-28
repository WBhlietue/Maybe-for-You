addBracket s = "[" ++ s ++ "]"

result = map(addBracket) ["one", "two"]

main = print(result)