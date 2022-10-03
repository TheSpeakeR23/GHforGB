import random

def elements_sum():
    n = int(input('Введите количество элементов в списке: '))
    if n > 0:
        rand_list = random.sample(range(1, 100), n)
        print(f'Список из произвольных чисел: {rand_list}')
        sum = 0
        for i in range(len(rand_list)):
            if i % 2 == 0:
                sum += rand_list[i]
        print(f'Сумма элементов, стоящих на нечетных позициях, равна: {sum}')
    else:
        print('Неправильный ввод количества элементов в списке')

elements_sum() 

