Console.Clear();

int[] numbers = new int[123];

void input_numbers (int[] Array){
  for (int i = 0; i < Array.Length; i++ ){
    Array[i] = new Random().Next();
  }
}

void WriteArray(int[] Array){
    for (int i = 0; i<Array.Length; i++ ){
    Console.Write(Array[i] + " ");
  }
  Console.WriteLine();
}

int Quantity(int[] Array){
    int quantity = 0;
    for (int i = 0; i<Array.Length; i++ ){
    if (Array[i] >= 10 && Array[i] <= 99)
    {
      quantity++;
    }
  }
  return quantity;
}

input_numbers(numbers);
WriteArray(numbers);
Console.WriteLine();

int quantity = Quantity(numbers);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {quantity}");

