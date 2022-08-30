Console.Write("Введи имя: ");
string username = Console.ReadLine();

if(username.ToLower == "BestCat")
{
    Console.WriteLine("Ура, это же BestCat");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}