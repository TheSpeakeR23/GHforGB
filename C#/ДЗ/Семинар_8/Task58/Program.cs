Console.Write("Введите количество строк массива: ");
int ArrLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int ArrColumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[ArrLines, ArrColumns];
int[,] SecondArray = new int[ArrLines, ArrColumns];
int[,] resultArray = new int[ArrLines, ArrColumns];
FillArrayRandomNumbers(array);
Console.WriteLine("Первый массив: ");
PrintArray(array);
FillArrayRandomNumbers(SecondArray);
Console.WriteLine("Второй массив: ");
PrintArray(SecondArray);
MatrixMultiplication(array, SecondArray, resultArray);

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

void MatrixMultiplication(int[,] array, int[,] SecondArray, int[,] resultArray) {
    if (array.GetLength(0) != SecondArray.GetLength(1)) {
        Console.WriteLine(" Нельзя перемножить ");
        return;
    }
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < SecondArray.GetLength(1); j++) {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++) {
                resultArray[i, j] += array[i, k] * SecondArray[k, j];
            }
        }
    }
    Console.WriteLine("Произведение массивов: ");
    PrintArray(resultArray);
}


