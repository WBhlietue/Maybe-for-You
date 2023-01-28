l1 = [1, 2, 3]
l2 = [4, 5, 6]

print(l1, "'s length = ", len(l1))

print(l1, "+", l2, " = ", l1 + l2)

print(l1, " x 4 =", l1 * 4)

print("2 in", l1, " is ", (2 in l1))

print(l2, "'s elements is")

for i in l2:
    print(i)

print("\n")

# 

n = int(input("n = "))
list = []

for i in range(n):
    a = int(input("a" + str(i) + " = "))
    list = list + [a]

list.sort()

n = ""

ans = []

for i in range(len(list) - 1):
    if(list[i] == list[i + 1] and list[i] != n):
        n = list[i]
        ans = ans + [n]

if(len(ans) == 0):
    print("ijil element baihgui")
else:
    print(ans)


# lab1 - 1
# lab2 - 1
# ...
# lab14 - 1

# soril 1, 2 onoo

# biy daalt - ilgeesen bol 1 ugu bol 0

# lectsiin devtriin onoo
