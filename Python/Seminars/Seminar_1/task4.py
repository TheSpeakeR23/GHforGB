# 4. Напишите программу, которая будет принимать на вход дробь и показывать первую цифру дробной части числа.

number = float(input('Введите значение N: '))
number = number * 10 % 100.
print(int(number))

