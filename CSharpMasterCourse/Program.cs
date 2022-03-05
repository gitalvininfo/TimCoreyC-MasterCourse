

string[] names = new string[] { "alvin0", "alvin1", "alvin2" };

Console.Write("Enter which index to select from 0 - 2: ");
string indexString = Console.ReadLine();

bool isValidIndex = int.TryParse(indexString, out int index);

if (isValidIndex)
{

    try
    {
        Console.WriteLine($"You selected {names[index]}");

    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("That index does not exist");
    }
}
else
{
    Console.WriteLine("That is not a number");
}



Console.Beep();
Console.ReadKey();
