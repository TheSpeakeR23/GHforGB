Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int[] copy = new int[numbers.Length];
numbers.CopyTo(copy, 0);
PrintCopy(numbers);

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array) {
    Console.Write("Исходный массив: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]\n");
}

void PrintCopy(int[] copy) {
    Console.Write("Копия исходного массива: [ ");
        for (int i = 0; i < copy.Length; i++) {
        Console.Write(copy[i] + " ");
        }
    Console.Write("]");
}