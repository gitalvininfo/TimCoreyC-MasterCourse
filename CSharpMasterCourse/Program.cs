

bool isContinue = true;


while (isContinue)
{

    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    int waitingYears = 21 - age;

    bool isProfessor = name.ToLower() == "bob" || name.ToLower() == "sue" || name.ToLower() == "tim";

    if (isProfessor)
    {
        Console.WriteLine("Hello Professor!");
    }

    else
    {
        Console.WriteLine("Hello Student!");
        if (age < 21)
        {
            Console.WriteLine($"You must wait {waitingYears} years to start class");
        }
        else
        {
            Console.WriteLine("Go to school user...");
        }
    }

    bool isValidResponse = false;

    while (!isValidResponse){
        Console.WriteLine("Do you want to continue? Y/N");
        string response = Console.ReadLine();

        if (response.ToLower() == "y")
        {
            isValidResponse = true;
            isContinue = true;
        }
        else if (response.ToLower() == "n")
        {
            isValidResponse = true;
            isContinue = false;
            Console.WriteLine("Thanks for playing...");
        }   else
        {
            isValidResponse = false;
        }
    }
}


Console.Beep();
Console.ReadKey();
