num = int(input("Enter number"))

binary = []

while num != 1 :
    binary.insert(0,num%2)
    num = num // 2
    
binary.insert(0,1)

out = ''.join(str(x) for x in binary)

print(out)