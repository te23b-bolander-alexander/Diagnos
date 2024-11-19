/*if (6 >= 3)
{
Console.writeline("Helll o world");
}
*/
/*
Console.WriteLine("what is your name");
string name = Console.ReadLine();
Console.WriteLine("Whats your password?");
string pass = Console.ReadLine();
if (name == "Kalleanka" && pass == "12345")
{
    Console.WriteLine("Welcome");
}
else
{
Console.WriteLine("wrong name and password");
}

Console.ReadLine();
*/
/*
int b = 0;
while (b < 32)
{
b++;
Console.WriteLine("hello world");
}
Console.ReadLine();
*/

/*
Console.WriteLine("whats is your name");
string name = Console.ReadLine();
string pass = "ollon";
while (pass != "12345")
{
 Console.WriteLine("what is your apssword");
 pass = Console.ReadLine();
}
*/

/*
using System.Text.Json.Serialization;

string tal = "2";
int i;
while (tal != "3")
{
    Console.WriteLine("gissa numret");
    tal = Console.ReadLine();
    int.TryParse(tal, out i);
    if (i < 3)
    {
        Console.WriteLine("för lågt");
    }
      if (i > 3)
    {
        Console.WriteLine("för högt");
    }
      if (i == 3)
    {
        Console.WriteLine("YIPPIE YIPPIE DU ÄR EN SIGMAAAAA");
    }


}
Console.ReadLine();
*/


string[] leksaker = ["docka", "boll", "transformer", "lego", "nintendo"];

foreach (string choice in leksaker)
{
    Console.WriteLine(choice);
}

Console.ReadLine();





