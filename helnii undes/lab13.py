# Factorial oloh (continue)

n = int(input("n = "))
fact = 1
for i in range(n + 1):
    if(i <= 0):
        continue
    fact = fact * i

print(n, "! = ", fact)


# Uguulberiin ehnii ug

str = input("input = ")
s = ""
for i in str:
    if(i == " "):
        break
    else:
        s = s + i

print(s)
