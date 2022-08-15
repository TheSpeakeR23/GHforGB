Console.Clear();
Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 & Number < 1000)
{    
    string stringNumber = Convert.ToString(Number);
    Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
}
else if (Number < -99 & Number > -1000)
{
    string stringNumber = Convert.ToString(Number);
    Console.WriteLine("вторая цифра этого числа -> "+stringNumber[2]);
}
else
{
    Console.WriteLine("Ошибка ввода данных!");
}