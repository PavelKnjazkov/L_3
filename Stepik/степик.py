#a = 42
#b = 4
#c = 2
#e = -2
#c = a // (b + c * e)
#print (c)
#a = 2014.0
#b = 14
#c = a ** 14
#print (c)
#print(float(1.2345e-3))
#a = 7
#b = 3
#c = a // b
 #print (c)
 #print(int(-1.6))
#a = -1.6
#b = int (a)
 #print (b)
#9**19 - int(float(9**19))
#a = 9
#b = 19
#c = a ** b
#d = int(float(9**19))
#f = c - d
 #print (f)
#x = 9 ** 19
#y = float(x)
#z = int(y)
 #print(x - z)
#a = int(input('Сколько Вам лет?'))
#N = int(input('Мы поможем узнать Ваш возраст через N лет. Введите значение N'))
#print('Через' , N ,'лет Вам будет ', a+N)
#name = input ('Ведите ваше имя ')
#print ('Hello ', name)
#a = int(input())
#b = int(input())
#print (a+b)
#a=int(input('Enter number 1: '))
#b=int(input('Enter number 2: '))
#print('You numbers', a, b)
#print('Sum a & b=', a+b)

#Катя узнала, что ей для сна надо XX минут. 
#В отличие от Коли, Катя ложится спать после полуночи в HH часов и MM минут. 
#Помогите Кате определить, на какое время ей поставить будильник, 
#чтобы он прозвенел ровно через XX минут после того, как она ляжет спать.

#На стандартный ввод, каждое в своей строке, подаются значения XX, HH и MM. 
#Гарантируется, что Катя должна проснуться в тот же день, что и заснуть. 
#Программа должна выводить время, на которое нужно поставить будильник: в первой строке часы, во второй — минуты.
x = int(input())
h = int(input())
m = int(input())
y = h*60 + m + x
print (int(y/60))
print (int(y%60))

# put your python code here
X = int(input())# Подаем на ввод число Х минут которые Катя должна проспать
H = int(input())# Подаем на ввод число Н ( во сколько часов ложиться спать)
M = int(input())# Подаем на ввод число М ( во сколько минут ложиться спать)
print((H * 60 + M + X) // 60)# Использую функцию целочисленного деления находим час на который надо поставить будильник
print((H * 60 + M + X) % 60)# Использую функцию нахождения остатка от деления находим минуту на которую надо поставить будильник

#optimal = int(input())
#hours = optimal // 60
#minutes = optimal % 60
#print(hours)
#print(minutes)
#sleepTime = int ( input() )
#hours = sleepTime // 60
#minuts = sleepTime % 60
#print (hours)
#print (minuts)