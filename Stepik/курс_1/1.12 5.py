'''
Напишите программу, которая получает на вход три целых числа, 
по одному числу в строке, и выводит на консоль в три строки 
сначала максимальное, потом минимальное, после чего оставшееся число.

На ввод могут подаваться и повторяющиеся числа.
'''

a=int(input())
b=int(input())
c=int(input())
Max=max(a,b,c)
Min=min(a,b,c)
Third=(a+b+c)-(Max+Min)
print (Max, Min, Third,sep='\n' )