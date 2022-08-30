Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int Summa(int Number) {
    while (Number > 0) {
    int num = Number % 10;
    Number = Number / 10;
    sum = sum + num;
    }
return sum;
}

sum = Summa(Number);
Console.WriteLine($"Cумма всех цифр числа {Number} равна: {sum}");
