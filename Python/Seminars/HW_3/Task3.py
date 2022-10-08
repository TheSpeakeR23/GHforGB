# 3. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
#    Без использования: встроенной функции преобразования, строк.

from unittest import result


def convert_to_bin(num: int):
    result = []

    while num > 0:
        result.insert(0, num % 2)
        num //= 2

    print(*result, sep="")


convert_to_bin(int(input("Введите число: ")))