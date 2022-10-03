import random

def elements_sum():
    n = int(input('Введите количество элементов в массиве: '))
    rand_list = random.sample(range(1, 100), n)
    print(f'Список из произвольных чисел: {rand_list}')
    sum = 0
    for i in range(len(rand_list)):
        if i % 2 == 0:
            sum += rand_list[i]
    print(sum)

elements_sum() 

