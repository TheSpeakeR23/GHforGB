Console.Write("Введите значение числа A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Значение A равное {numberA} больше чем значение B равное {numberB}");
}
else if (numberA == numberB)
{
    Console.WriteLine($"Значение A равно значению B");
}
else
{    
    Console.WriteLine($"Значение B равное {numberB} больше чем значение A равное {numberA}");
}
