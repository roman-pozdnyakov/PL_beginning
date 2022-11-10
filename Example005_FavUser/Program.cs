Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "прокл")
{
    Console.WriteLine("Наконец-то ты вернулся!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}