Console.Write("Введите количество строк массива: ");
int ArrLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int ArrColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[ArrLines, ArrColumns];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Исходный массив: ");
PrintArray(numbers);
SumElementsInLine(numbers, 0);
MinSum(numbers);

void FillArrayRandomNumbers(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumElementsInLine(int[,] array, int i) {
    int SumLine = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++) {
            SumLine += array[i, j]; 
        }
    return SumLine;
}

void MinSum(int[,] array) {
    int MinSumLine = 0;
    int SumLine = SumElementsInLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++) {
        int MinLine = SumElementsInLine(array, i); 
        if (SumLine > MinLine) {
            SumLine = MinLine;
            MinSumLine = i;
        }
    }
    Console.Write($"Наименьшую сумму ({SumLine}) элементов имеет {MinSumLine + 1} строка");
}
