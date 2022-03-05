
string response = "";
bool isValidResponse = false;

do
{

    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Hello Professor {name}.");
    }
    else
    {
        Console.WriteLine("Hello Student.");
    }


    do
    {
        Console.Write("Continue? Y/N: ");
        response = Console.ReadLine();

        response = response.ToLower();

        if (response.ToLower() != "y" && response.ToLower() != "n")
        {
            isValidResponse = false;
        }
        else
        {
            isValidResponse = true;
        }

        if(response.ToLower() == "n")
        {
            Console.WriteLine("Goodbye :P");
        }

    } while (!isValidResponse);


} while (response == "y");


Console.Beep();
Console.ReadKey();
