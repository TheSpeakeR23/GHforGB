# 5. Напишите программу, которая принимает на вход координаты
#    двух точек и находит расстояние между ними в 2D пространстве.
#    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

x1 = int(input('Введите координату X точки A: '))
y1 = int(input('Введите координату Y точки A: '))
x2 = int(input('Введите координату X точки B: '))
y2 = int(input('Введите координату Y точки B: '))

result = round(((x2 - x1) ** 2 + (y2 - y1) ** 2) ** 0.5, 4)
print(f"Расстояние между точками A и B в 2D пространстве равно {result}")

