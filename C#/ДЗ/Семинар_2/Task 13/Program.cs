Console.Clear();
Console.Write("Введите любое число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99)
{    
    string stringNumber = Convert.ToString(Number);
    Console.WriteLine("Третья цифра этого числа -> "+stringNumber[2]);
}
else if (Number < -99)
{
    string stringNumber = Convert.ToString(Number);
    Console.WriteLine("Третья цифра этого числа -> "+stringNumber[3]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}