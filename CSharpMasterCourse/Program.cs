


List<string> firstNames = new List<string>();

firstNames.Add("alvin1");
firstNames.Add("alvin2");
firstNames.Add("alvin3");
firstNames.Add("alvin4");
firstNames.Add("alvin5");

Console.WriteLine(firstNames[firstNames.Count - 1]);

string data = "Corey,Tim,Jones,Frank";
List<string> lastNames = data.Split(",").ToList();
lastNames.Add("Alvin");

foreach(string lastName in lastNames)
{
    Console.WriteLine(lastName);
}








Console.Beep();
Console.ReadKey();
