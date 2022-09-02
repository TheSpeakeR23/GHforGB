double[] Array = new double[10];
  for (int i = 0; i < Array.Length; i++ )
  {
    Array[i] = new Random().Next(1, 10);
    Console.Write(Array[i] + " ");
  }

double maxNumber = Array[0];
double minNumber = Array[0];

  for (int i = 1; i < Array.Length; i++)
  {
    if (maxNumber < Array[i])
    {
      maxNumber = Array[i];
    }
        if (minNumber > Array[i])
    {
      minNumber = Array[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nРазница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами массива: {decision}");
