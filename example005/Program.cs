Console.WriteLine("Введите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "илья")
{
    Console.WriteLine("Ура");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}