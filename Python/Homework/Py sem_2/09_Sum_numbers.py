"""
Требуется посчитать сумму чётных чисел, расположенных между числами 1 и N включительно.
"""

a=int(input("a = "))
b=int(input("b = "))
sum_numbers = 0
for i in range(a, b + 1):
    if i % 2 == 0:
        sum_numbers += i
print(sum_numbers)
