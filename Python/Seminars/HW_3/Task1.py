# 1. Задайте список, состоящий из произвольных чисел, количество задаёт пользователь.
#    Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётных позициях(не индексах).

import random

# def elements_sum():
#     n = int(input('Введите количество элементов в списке: '))
#     if n > 0:
#         rand_list = random.sample(range(1, 100), n)
#         print(f'Список из произвольных чисел: {rand_list}')
#         sum = 0
#         for i in range(n):
#             if i % 2 == 0:
#                 sum += rand_list[i]
#         print(f'Сумма элементов, стоящих на нечетных позициях, равна: {sum}')
#     else:
#         print('Неправильный ввод количества элементов в списке')

# elements_sum() 

def random_list(n):
    rand_list = random.sample(range(1, 100), n)
    return rand_list 


def sum_of_odd_elements(rand_list):
    sum_odd = 0
    for i in range(n):
        if i % 2 == 0:
            sum_odd += rand_list[i]
    return sum_odd

def sum_of_even_elements(rand_list):
    sum_odd = 0
    for i in range(n):
        if i % 2 != 0:
            sum_odd += rand_list[i]
    return sum_odd  

n = int(input('Введите количество элементов в списке: '))
if n > 0:
    rand_list = random_list(n)
    print(f'Список из произвольных чисел: {rand_list}')
    print(f'Сумма элементов, стоящих на нечетных позициях, равна: {sum_of_odd_elements(rand_list)}')
    print(f'Сумма элементов, стоящих на четных позициях, равна: {sum_of_even_elements(rand_list)}')
else:
    print('Неправильный ввод количества элементов в списке')