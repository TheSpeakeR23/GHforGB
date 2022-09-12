Console.Write("Введите количество строк: ");
int ArrLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int ArrColumns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[ArrLines, ArrColumns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
ArithmeticMean(numbers);

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

void ArithmeticMean(double[,] array) {
    for (int j = 0; j < array.GetLength(1); j++) {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) {
            sum += array[i, j];
        }
    Console.Write($"{ sum / array.GetLength(0)} ");
    }
}
