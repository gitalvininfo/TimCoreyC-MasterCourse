

using CSharpMasterCourse;

List<string> users = new();
List<int> guests = new();

bool isContinue = true;
string response = "";
bool isValidResponse = false;

do
{
    string name = GuestBook.GetUserName();
    users.Add(name);

    int num = GuestBook.GetNumberOfPeople();
    guests.Add(num);

    do
    {
        Console.Write("Do you want to continue. Y/N: ");
        response = Console.ReadLine();

        if (response.ToLower() != "y" && response.ToLower() != "n")
        {
            isValidResponse = false;
        }   else
        {
            isValidResponse = true;
        }

        if(response.ToLower() == "n")
        {
            Console.WriteLine("The users are the following: ");
            foreach (string user in users)
            {
                Console.Write(user + ", ");
            }

            int total = 0;
            foreach(int guest in guests)
            {
                total += guest;
            }
            Console.WriteLine("The total number of guests is: " + total);


        }

    } while (!isValidResponse);

} while (response.ToLower() == "y");

Console.Beep();
Console.ReadKey();
