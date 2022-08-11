Console.Clear();
int numberA = new Random().Next(1, 100);
Console.WriteLine($"Случайное значение числа A равно {numberA}");
int numberB = new Random().Next(1, 100);
Console.WriteLine($"Случайное значение числа B равно {numberB}");
int result = numberA + numberB;
Console.WriteLine($"Сумма чисел A и B равна {result}");
