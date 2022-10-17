# 2. Задайте натуральное число N. Напишите программу,
#    которая составит список простых множителей числа N.

def find_prime_nums(num):
    prime_factors = []
    n = 2
    while num > 1:
        if num % n == 0:
            prime_factors.append(n)
            num //= n
        else:
            n += 1
    return prime_factors


# 650, 9990, 364, 54
print(find_prime_nums(int(input("Enter a number: "))))