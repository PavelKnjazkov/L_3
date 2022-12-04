# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

# Решение с семинара:

spisok = input("Введите список из нескольких чисел чурез пробел\n").split() # split превратил строчку в список
list = []
i = 0
while (i < len(spisok)//2 + len(spisok)%2): # %2 для нечетного среднего элемента, если в списке 6 элементов то будет 0
    numb = len(spisok) - i - 1
    list.append(int(spisok[i]) * int(spisok[numb]))
    i+=1
print(list)

# # Еще способ:

# from random import randint
# import math

# def get_numbers(n, frst, last):
#     return [randint(frst, last) for i in range(n)]

# def mult_pairs(mylist):
#     return [mylist[i] * mylist[-i - 1] for i in range(math.ceil(len(mylist)/2))]

# n = 9
# frst = 1
# last = 10

# mylist = get_numbers(n, frst, last)
# print(mylist)
# print(mult_pairs(mylist))


# # Еще способ:

# def pairs_mult(numbers):
#     results = []
#     while len(numbers) > 1:
#         results.append(numbers[0]*numbers[-1])
#         del numbers[0] 
#         del numbers[-1] 
#     if len(numbers) ==1: results.append(numbers[0]**2)       
#     return results

# print(pairs_mult(mylist))