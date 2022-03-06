
bool isContinue = true;
bool isValidResponse = false;
string response = "";


List<string> studentNames = new List<string>();

do
{
    Console.Write("Enter Student name: ");
    string name = Console.ReadLine();
    studentNames.Add(name);

    do
    {
        Console.Write("Student added... Continue Y/N: ");
        response = Console.ReadLine();

        if(response.ToLower() != "y" && response.ToLower() != "n")
        {
            isValidResponse = false;
        }
        else
        {
            isValidResponse = true;
        }

        if (response.ToLower() == "y")
        {
            isContinue = true;
        }
        else
        {
            Console.WriteLine($"Total count of students is {studentNames.Count}");
            isContinue = false;
        }

    } while (!isValidResponse);



} while (isContinue);



Console.Beep();
Console.ReadKey();
