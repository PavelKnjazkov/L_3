# 2. Напишите программу, удаляющую из текста все слова, содержащие "абв".Строка находится в файле.
# Пример: ывпвап вапапро приветабв привет приветаб
# Вывод: ывпвап вапапро привет приветаб


with open('file_task#2.txt', encoding='utf-8') as file: # открыт для чтения
       data = file.readline()

print(data)
data = [word for word in data.split() if 'абв' not in word]
print(' '.join(data))
