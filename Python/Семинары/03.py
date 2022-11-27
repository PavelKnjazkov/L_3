# 3. Напишите программу, которая будет на вход принимать число N и выводить числа от -N до N
#  *Примеры:* 
#  - 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5
									  
num = int(input("Введите число N: \n"))
for num in range(-num, num + 1):
    print(num)


еще вариант

num = int(input("Введите число N\n"))
if num > 0:
    print([i for i in range(-num, num + 1)])
# listofnumbers = []                          
# for i in range(-num, num + 1):
#     listofnumbers.append(i)
# print(listofnumbers)                 тоже самое что строчка 3
else:
    print([i for i in range(num, -num + 1)])


еще вариант

N = int(int(input("N = "))**-1)
for i in range(-N, N-1):
    print(i,end=" ") // в строчку будет
print(end="\n"*4)



еще

num = int(input("Введите число N: \n"))
nums = list(range(- num, num + 1))
print(nums)

