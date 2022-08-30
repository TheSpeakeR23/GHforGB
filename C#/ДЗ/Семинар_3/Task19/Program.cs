int main() {
    int Number;
    string StrNumber;
    Console.Write("Введите пятизначное целое число: ");
    Number = Convert.ToInt32(Console.ReadLine());
    if (Number > 9999 && Number < 100000) {
        StrNumber = Convert.ToString(Number);
        if (StrNumber[0] == StrNumber[4] && StrNumber[1] == StrNumber[3]) {
            Console.WriteLine($"Ваше число: {Number} - является палиндромом");
        } else {
            Console.WriteLine($"Ваше число: {Number} - НЕ является палиндромом");
        }
    } else {
        Console.WriteLine("Некорректный ввод данных. Введите пятизначное целое число.");
    }
return 0;
}

main();