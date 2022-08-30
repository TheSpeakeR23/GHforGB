Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

int cycle(int a, int b) {
    for (int i = 1; i < b; i++) {
    step = step * a;
    }
return step;
}

step = cycle(a, b);
Console.WriteLine($"{a} в степени {b} равно: {step}");