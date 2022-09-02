Console.Clear();

int[] numbers = new int[10];

void FillArray(int[] Array, int min, int max){
  for (int i = 0; i < Array.Length; i++ ){
    Array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] Array){
    for (int i = 0; i<Array.Length; i++ ){
    Console.Write(Array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] Array){
    int quantity = 0;
    for (int i = 0; i<Array.Length; i++ ){
    if (Array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

