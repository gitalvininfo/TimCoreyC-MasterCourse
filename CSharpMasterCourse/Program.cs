
bool isContinue = true;
string response = "";

List<string> studentNames = new List<string>();

do
{
    Console.Write("Enter Student name: ");
    string name = Console.ReadLine();
    studentNames.Add(name);

    Console.Write("Student added... Continue Y/N: ");
    response = Console.ReadLine();
    if(response.ToLower() == "y")
    {
        isContinue = true;
    }
    else
    {
        Console.WriteLine($"Total count of students is {studentNames.Count}");
        isContinue = false;
    }



} while (isContinue);



Console.Beep();
Console.ReadKey();
