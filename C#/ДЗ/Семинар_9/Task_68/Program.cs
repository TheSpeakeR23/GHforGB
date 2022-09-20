Console.Clear();

Console.Write("Введите значение числа M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0) {
    Console.Write($"Функция Аккермана для чисел A({m},{n}) = ");
    AkkermanFunction(m,n);
} else {
    Console.WriteLine("Некорректный ввод данных...");    
}

void AkkermanFunction(int m, int n) {
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0 && m > 0) {
        return Akkerman(m - 1, 1);
    } else {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}