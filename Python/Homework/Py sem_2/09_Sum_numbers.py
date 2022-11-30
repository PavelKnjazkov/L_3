# Требуется посчитать сумму чётных чисел, расположенных между числами 1 и N включительно.

"""
n = int(input())
sum = 0
for i in range (1+n):
    if i % 2 == 0:     # если делится без остатка на 2
        sum += i       # записываем его в сумму
print(f'Cумма четных чисел, м/у числами 1 и {n} включительно, равна: \n {sum}')
"""

n = int(input())
sum = 0
for i in range (2, 1+n, 2): #начинаем с 2 до n, с шагом 2...
    sum += i       # записываем его в сумму
print(f'Cумма четных чисел, м/у числами 1 и {n} включительно, равна: \n {sum}')


"""
a=int(input("a = "))
b=int(input("b = "))
sum_numbers = 0
for i in range(a, b + 1):
    if i % 2 == 0:
        sum_numbers += i
print(sum_numbers)
"""