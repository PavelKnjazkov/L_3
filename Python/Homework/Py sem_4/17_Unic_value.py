# Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
# (Вывод тех элементов, которые были без повторов)
# Ввод: 1 2 3 2 4 4
# Вывод: 1 3 4

# lst = list(map(int, input("Введите числа через пробел:\n").split()))
# print(f"Исходный список: {lst}")
# new_lst = []
# [new_lst.append(i) for i in lst if i not in new_lst]
# print(f"Список из неповторяющихся элементов: {new_lst}")


from random import randint

def create_list(size, m, n):
    return [randint(m, n) for i in range(size)]

def get_unic_value(list):
    return [i for i in set(list)]

size = 10
m = 1
n = 10

origin = create_list(size, m, n)
print(origin)
print(get_unic_value(origin))