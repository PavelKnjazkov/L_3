# Вычислить число Pi c заданной точностью d, не используя ф. round()
# Пример:
# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

# Решение с семинара

from math import pi

num = int(input())
stroka = str(pi)
print(float(stroka[0:num+2]))

# import math

# pi = math.pi
# print('Pi = ', pi)
# d = 0.001
# print(f'Accuracy = {d}')
# count = 0
# while d < 1:
#     count += 1
#     d = d*10
# print(round(pi, count))


## РЕШЕНИЕ)))

# from math import pi

# d =  int(input("Введите число для заданной точности числа Пи:\n"))
# print(f'число Пи с заданной точностью {d} равно {round(pi, d)}')


## Просто Pi

# # Формула Бэйли — Боруэйна — Плаффа

# n = 100
# my_pi = sum(1/16**x*(4/(8*x + 1) - 2/(8*x + 4) - 1/(8*x + 5) - 1/(8*x + 6)) for x in range(n))

# print(my_pi)


# # Ряд Лейбница

# n = 20000000

# mypi = 4 * (sum(1/x for x in range(1, n + 1, 4)) +
#             sum(-1/x for x in range(3, n + 1, 4)))

# print(format(mypi, '.100'))