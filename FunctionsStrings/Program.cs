// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string myString = "Bienvenido Gabriel";
string stringEmpty = string.Empty;
string stringNull = null;
string stringName = "Gabriel";

if (string.IsNullOrEmpty(stringNull))
{
    Console.WriteLine("Error");
}
Console.WriteLine(myString.Length);
Console.WriteLine(stringEmpty.Length);
Console.WriteLine(myString.ToLower());
Console.WriteLine(myString.ToUpper());

if (myString.Contains(stringName))
{
    Console.WriteLine("Si contiene " + stringName);
}

if (myString.Equals("Juan"))
{
    Console.WriteLine("Bienvenido Juan");
}
else
{
    Console.WriteLine(myString);
}