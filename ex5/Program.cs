// Task ex5. Написать задачу с распознованием имени пользователя и специального приветсвия

Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "artem")
{
    Console.Write("hello the best: " + username);
}
else
{
    Console.Write("hello: " + username);
}
