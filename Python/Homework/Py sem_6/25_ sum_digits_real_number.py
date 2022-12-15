# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

# Пример:
# - 6782 -> 23
# - 0,56 -> 11

# x = input('Введите число ')

# def summa(x):                    #Функция нахождения суммы чисел в заданном числе
#     if float(x) < 0:                            
#         x = float(x) * (-1)
#     number = 0

#     for i in str(x):
#         if i != '.':                    #Проверка на знак перед числом
#             number += int(i)
#     return number

# print(f'Сумма чисел равна {summa(x)}')


## еще решение

def sum_digits(num):
    return sum(map(int, num.replace('.','').replace('-','')))

num = input('Введите любое вещественное число: ')
print(f'Сумма цифр в этом числе равна {sum_digits(num)}')

# Если на вход попадает значение типа float, то достаточно перевести значение в тип str (str(num).replace...)

# # Решение с семинара:

# def summa(num):
#     return sum(map(int, num.replace(".","").replace("-","")))

# num = input ("Введите число: ")
# print(f"Сумма цифр в числе: {summa(num)}")