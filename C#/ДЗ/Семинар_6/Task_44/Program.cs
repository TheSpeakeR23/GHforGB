int n, first = 0, second = 1, third = 0;
Console.Write("Сколько первых элементов ряда Фибоначчи вывести на экран : ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Первые {0} элементов ряда Фибоначчи {1} {2} ", n, first, second);
    for (int i = 3; i <= n; i++) {
        third = first + second;
            Console.Write("{0} ", third);
            first = second;
            second = third;
        }