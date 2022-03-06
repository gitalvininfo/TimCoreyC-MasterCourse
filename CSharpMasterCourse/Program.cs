

Console.Write("Enter the names in comma separated: ");
string data = Console.ReadLine();

string[] names = data.Split(",");

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello {names[i]}");
}


Console.Beep();
Console.ReadKey();
