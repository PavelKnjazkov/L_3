# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

# Решение с семинара:

n = int(input())
b = ""
while n > 0:
    b = str(n%2)+ b
    n = n // 2
print(b)


# # Другие решения

# num = int(input('введите десятичное число: '))
# binary = 0 # начальное значение двоичного числа
# k = 1    #начальная позиция в двоичной записи
# while num > 0:
#     div = num % 2
#     binary = binary + div*k # полученный остаток от деления должен стоять впереди уже имеющихся, поэтому повышаем его разряд
#     num = num // 2
#     k *= 10

# # Другие решения

# def conv_dec_to_bin(n):
#     bin_num = ''
#     while n > 1:
#         bin_num += str(n % 2)
#         n = n // 2
#     return bin_num[::-1]

# print(conv_dec_to_bin(n))

# # Другие решения

# def convert_dec_to_bin(n):
#     bin_num = []
#     while n > 1:
#         bin_num.insert(0, n % 2)
#         n = n // 2
#     return bin_num

# print(convert_dec_to_bin(n))

# print(bin(n).replace('0b1',''))