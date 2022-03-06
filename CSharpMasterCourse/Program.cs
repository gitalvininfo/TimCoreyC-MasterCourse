

string data = "Tim,Corey,Jane,Sue";
List<string> names = data.Split(",").ToList();


foreach(string name in names)
{
    Console.WriteLine(name);
}

Console.Beep();
Console.ReadKey();
