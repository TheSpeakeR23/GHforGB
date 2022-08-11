Console.Write("Введите значение числа N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i=0;
while (i <= numberN)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;  
}
