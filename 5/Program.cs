
Console.WriteLine("Введите имя пользователя: ");
string x = Console.ReadLine();

if(x.ToLower() == "петя")
{
    Console.WriteLine("Ура, это же том самый красавчик Петя!");
}
else
{
    Console.Write("Здрасти, а где Петя? ");
    Console.WriteLine(x);
}