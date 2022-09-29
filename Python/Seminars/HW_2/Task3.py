# 3. Задайте список из n чисел, заполненный по формуле 
#    (1 + 1/n) ** n и выведите на экран их сумму.

number = int(input('Введите значение числа N: '))

sequence = [round((1+1/i)**i) for i in range(1, number+1)]
print(f'Последовательность: {sequence}\nСумма: {round(sum(sequence), 3)}')
