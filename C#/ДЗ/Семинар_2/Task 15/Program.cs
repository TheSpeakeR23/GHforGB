Console.Clear();
Console.Write("Введите какой сегодня день недели от 1 до 7: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 1 & Number <= 7)
{
    if (Number == 7)
    {
        Console.WriteLine("Сегодня воскресенье - выходной день.");
    }
    else if (Number == 6)
    {
        Console.WriteLine("Сегодня суббота - выходной день.");
    }
    else if (Number == 5)
    {
        Console.WriteLine("Сегодня пятница - рабочий день.");
    }
    else if (Number == 4)
    {
        Console.WriteLine("Сегодня четверг - рабочий день.");
    }
    else if (Number == 3)
    {
        Console.WriteLine("Сегодня среда - рабочий день.");
    }
    else if (Number == 2)
    {
        Console.WriteLine("Сегодня вторник - рабочий день.");
    }
    else if (Number == 1)
    {
        Console.WriteLine("Сегодня понедельник - начало рабочей недели.");
    }
}
else
{
    Console.WriteLine("Ошибка ввода дынных!");
}