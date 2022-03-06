
List<string> names = new();
String name;
String response = "";
bool isValidResponse = false;


do
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    names.Add(name);


    do
    {
        Console.Write("Name added. Continue Y/N: ");
        response = Console.ReadLine();
        response = response.ToLower();


        if (response == "y" || response == "n")
        {
            isValidResponse = true;

        }
        else
        {
            isValidResponse = false;

        }

        if (response == "n")
        {
            foreach (string uname in names)
            {
                Console.WriteLine($"Hello {uname}");
            }
        }


    } while (!isValidResponse);


} while (response == "y");



//if == it must be response == "y" || response == "n"

//if && it must be response != "y" && response != "n"

Console.Beep();
Console.ReadKey();
