﻿Console.Write("Введите количество строк массива: ");
int ArrLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int ArrColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[ArrLines, ArrColumns];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив до изменения: ");
PrintArray(numbers);
Console.WriteLine("Массив после сортировки: ");
SortArray(numbers);
PrintArray(numbers);

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

void SortArray(int[,] array) {
    for (int i = 0; i < numbers.GetLength(0); i++) {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++) {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++) {
                if (numbers[i, z] < numbers[i, z + 1]) {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
}
