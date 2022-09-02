Console.Clear();

Console.Write($"Введи количество элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int N, int min, int max)
  {
  int[] randomArray = new int[N];
  int SumNumbers = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomArray.Length; i++ ){
      randomArray[i] = new Random().Next(min, max);

      Console.Write(randomArray[i] + " ");

      if (i % 2 != 1)
      {
        SumNumbers = SumNumbers + randomArray[i];
      }
    }
  return SumNumbers;
  }

int randomArray =  RandomNumbers(N, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomArray}");