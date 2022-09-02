int main() {
    Console.Write("Введите количество элементов N в массиве: ");
    int N = int.Parse(Console.ReadLine());
    if (N > 0) {
        int[] Array = new int[N];
        for (int i = 0; i < Array.Length; i++) {
            Console.Write("Введите {0}-й элемент: ", i + 1);
            Array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Вывод массива: ");
        for (int i = 0; i < Array.Length; i++) {
            Console.Write($"{Array[i]} ");
        }

    } else {
        Console.WriteLine("Некорректный ввод данных");
    }
    return 0;
}

main();

