'''
Требуется определить, является ли данный год високосным.

Напомним, что високосными годами считаются те годы, 
порядковый номер которых либо кратен 4, но при этом не кратен 100, 
либо кратен 400 (например, 2000-й год являлся високосным, а 2100-й будет невисокосным годом).

Программа должна корректно работать на числах 1900≤n≤3000.

Выведите «Високосный» в случае, если считанный год является 
високосным и «Обычный» в обратном случае (не забывайте проверять регистр выводимых программой символов).
'''
'''
a = int(input())
if a % 4 == 0 and a % 100 != 0 or a % 400 == 0:
    print("Високосный")
else:
    print("Обычный")

    # put your python code here
import calendar
year = int(input())
if calendar.isleap(year):
    print ("Високосный")
else:
    print ("Обычный")
'''
len ('ab')
'acd' * 3

a = '123'
b = '42'
print (a + b)

