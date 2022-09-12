Console.Write("Введите количество строк массива: ");
int ArrLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int ArrColumns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[ArrLines, ArrColumns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int ElementLine = ReadInt("Введите номер строки элемента: ");

int ElementColumn = ReadInt("Введите номер столбца элемента: ");

if (ElementLine - 1 < numbers.GetLength(0) && ElementColumn - 1 < numbers.GetLength(1)) Console.WriteLine(numbers[ElementLine - 1, ElementColumn - 1]);
else Console.WriteLine($"{ElementLine}{ElementColumn} -> такого числа в массиве нет");

void FillArrayRandomNumbers(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
