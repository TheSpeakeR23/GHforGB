Console.Clear();

Console.Write("Введите значение числа M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n) {
    Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна ");
    SumFromMToN(m, n);
} else {
    Console.WriteLine("Некорректный ввод данных...");    
}

void SumFromMToN(int m, int n) {
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n) {
    int res = m;
    if (m == n) {
        return 0;
    } else {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
