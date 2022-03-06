

Dictionary<int, string> employees = new Dictionary<int, string>();


employees[1] = "alvin1";
employees[2] = "alvin2";
employees[3] = "alvin3";
employees[4] = "alvin4";
employees[5] = "alvin5";

Console.Write("Please choose employee 1-5: ");
string idString = Console.ReadLine();

bool isValidID = int.TryParse(idString, out int id);

if(isValidID)
{
    if (id <= 5)
    {
        Console.WriteLine($"The employee is {employees[id]}.");
    }
    else
    {
        Console.WriteLine("That employee does not exist.");
    }
}
else
{
    Console.WriteLine("That is not a number");
}




Console.Beep();
Console.ReadKey();
