# 2. Напишите программу, которая принимает на вход число N 
#    и выдает набор произведений чисел от 1 до N.

number = int(input('Введите значение числа N: '))

result = 1
for i in range(1, number+1):
    result *= i
    print(result, end=' ')
