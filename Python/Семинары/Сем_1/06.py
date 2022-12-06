2) Напишите программу, в которой пользователь будет задавать две строки, одна из них - буква, а вторая фраза/слово,
программа должна посчитать сколько раз буква встретилась буква во второй строке. (Не используя встроенные функции)


decimal = input('Введите десятичную дробь.\n')
if ',' in decimal:
    decimal_part = decimal.split(',')[1]
    first_digit_of_dp = decimal_part[:1]
    print(first_digit_of_dp)
elif '.' in decimal:
    decimal_part = decimal.split('.')[1]
    first_digit_of_dp = decimal_part[:1]
    print(first_digit_of_dp)
else:
    print('Число не распознано как дробное.')

