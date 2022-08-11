// Ввод значения A
Console.Write("Введите значение числа A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

// Пишем условие задачи
if (numberA % 2 ==0)
{
    Console.WriteLine($"Число {numberA} - четное число"); // Вывод на экран
}
else
{
     Console.WriteLine($"Число {numberA} - нечетное число"); // Вывод на экран
}
