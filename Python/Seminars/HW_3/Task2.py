# 2. Напишите программу, которая найдёт произведение пар чисел списка.
#    Парой считаем первый и последний элемент, второй и предпоследний и т.д.

import random

def random_list(n):
    rand_list = random.sample(range(1, 100), n)
    return rand_list 

def mult_pairs(rand_list):
    results = []
    while len(rand_list) > 1:
        if len(rand_list) % 2 == 1:
            results.append(rand_list[0]*rand_list[-1])
            del rand_list[0] 
            del rand_list[-1]
            if rand_list[0] == rand_list[-1]:
                results.append(rand_list[0])
        else:
            results.append(rand_list[0]*rand_list[-1])
            del rand_list[0] 
            del rand_list[-1]
    return results

n = int(input('Введите количество элементов в списке: '))
if n > 0:
    rand_list = random_list(n)
    print(f'Список из произвольных чисел: {rand_list}')
    print(f'Произведение парных элементов списка: {mult_pairs(rand_list)}')
