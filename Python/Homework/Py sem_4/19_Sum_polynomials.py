# Дополнительное 
# Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.
# Файл1: 2*x² + 4*x + 5
# Файл2: 41*x^3 + 6*x² + 2*x + 98
# Вывод Файл3: 41*x^3 + 8*x^2 + 6*x + 103

with open('poly_1.txt', 'w', encoding='utf-8') as file:
    file.write('2*x^2 + 5*x + 5')
with open('poly_2.txt', 'w', encoding='utf-8') as file:
    file.write('41*x^3 + 6*x² + 2*x + 98')

with open('poly_1.txt','r') as file:
    poly_1 = file.readline()
    list_of_poly_1 = poly_1.split()


with open('poly_2.txt','r') as file:
    poly_2 = file.readline()
    list_of_poly_2 = poly_2.split()

print(f'{list_of_poly_1} + {list_of_poly_2}')
sum_poly = list_of_poly_1 + list_of_poly_2

with open('sum_poly.txt', 'w', encoding='utf-8') as file:
    file.write(f'{list_of_poly_1} + {list_of_poly_2}')