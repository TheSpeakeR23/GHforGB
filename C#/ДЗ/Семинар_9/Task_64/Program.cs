Console.Clear();
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number >= 1) {
    Console.WriteLine($"Последовательность натуральных чисел от {number} до 1:");
    NaturalToLow(number, count);
}
else {
    Console.WriteLine("Некорректный ввод данных...");
}

void NaturalToLow(int n, int count) {
    if (count > n) {
        return;
    } else {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}
