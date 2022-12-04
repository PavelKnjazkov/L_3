# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

# from random import randint

# def get_list(n, frst, last):
#     return [randint(frst, last) for i in range(n)]

# def sum_odd_position(mylist):
#     return sum(mylist[1::2])

# n = 10
# frst = 1
# last = 10

# mylist = get_list(n, frst, last)
# print(mylist)
# print(sum_odd_position(mylist))

# еще решение с семинара:

spisok = input("Введите список из нескольких чисел чурез пробел\n").split() # split превратил строчку в список
print(spisok)
sum = 0
for i in range (1, len(spisok), 2): # 2-ка это шаг
        sum += int (spisok[i]) # int - строку в число
print(sum)