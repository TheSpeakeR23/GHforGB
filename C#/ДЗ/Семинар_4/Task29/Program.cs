Console.Write("Введите количество элементов N в массиве: ");
int N = int.Parse(Console.ReadLine());
int[] myArray = new int[N];
for (int i = 0; i < myArray.Length; i++) {
    Console.Write("Введите {0}-й элемент: ", i + 1);
    myArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива:");
for (int i = 0; i < myArray.Length; i++) {
    Console.Write($"{myArray[i]}, ");
}


