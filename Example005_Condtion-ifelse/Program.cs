Console.Write("Enter user's name: ");
string username = Console.ReadLine();
if (username.ToLower() == "masha")
{
    Console.WriteLine("Huray!This is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}