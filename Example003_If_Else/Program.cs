Console.WriteLine("Привет путник! Как тебя зовут?");
string username = Console.ReadLine();

if (username.ToLower() == "Миша")
{
    Console.WriteLine("Вот это имя боготырское! АХ-ХА-ХА");
}
if (username.ToLower() == "ирина")
{
    Console.WriteLine("Привет, Иришка! Какая ты красивая сегодня!");
}
if (username == "")
{
    Console.WriteLine("Ну ты дурак?");
}
else
{
    Console.WriteLine("Привет, " + username);
}