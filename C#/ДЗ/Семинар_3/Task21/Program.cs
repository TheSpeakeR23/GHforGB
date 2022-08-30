int main() {
    double length,
           X1, Y1, Z1,
           X2, Y2, Z2;

    Console.WriteLine("Введите координаты точки A в 3D пространстве: ");
    Console.Write("X: ");
    X1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y: ");
    Y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z: ");
    Z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B в 3D пространстве: ");
    Console.Write("X: ");
    X2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y: ");
    Y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z: ");
    Z2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine($"Координаты точки А: {X1}, {Y1}, {Z1}");
    Console.WriteLine($"Координаты точки B: {X2}, {Y2}, {Z2}");

    Console.WriteLine("Нахождение расстояния между точками в 3D пространстве:");
    length = Math.Sqrt(Math.Pow(X2- X1, 2) + Math.Pow(Y2-Y1, 2) + Math.Pow(Z2 - Z1, 2));
    Console.WriteLine($"Расстояние между двумя точками равно: {length}");
return 0;
}

main();
