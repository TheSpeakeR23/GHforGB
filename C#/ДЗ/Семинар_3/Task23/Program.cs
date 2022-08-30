int main() {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    double cube;
    while (count <= number) {
        cube = Math.Pow(count, 3);
        Console.WriteLine(cube);
        count++;
    }
return 0;
}

main();
