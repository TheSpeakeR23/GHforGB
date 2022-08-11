Console.Clear();
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Николай")
{
    Console.WriteLine("Ура, это же НИКОЛАЙ!");
}
else
{
    Console.WriteLine($"Привет, {username}!");
}