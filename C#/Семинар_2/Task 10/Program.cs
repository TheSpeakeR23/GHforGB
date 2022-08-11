Console.Clear();
Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
