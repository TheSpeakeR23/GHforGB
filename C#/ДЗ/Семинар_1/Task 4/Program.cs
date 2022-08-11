// Ввод значения А
Console.Write("Введите значение числа A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

// Ввод значения В
Console.Write("Введите значение числа B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Вводим значение С
Console.Write("Введите значение числа C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

// Присваиваем значению A max
int max = numberA;

// Сравниваем значения B и C с max
if (numberB>max)
{
max=numberB;
}
if (numberC>max)
{
max=numberC;
}

// Вывод максимального значения
 Console.WriteLine($"Максимальное значение равно {max}");
