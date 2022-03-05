

bool isValidAge;
int age;
//int testNumber = 0;

//do
//{
//    Console.WriteLine(testNumber);
//    testNumber++;
//} while (testNumber != 10);


do
{
    Console.Write("Enter your age: ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (!isValidAge)
    {
        Console.WriteLine("That was an invalid age");
    }

} while (!isValidAge);

Console.WriteLine("You are valid age");




// runs the code at least once.
//do
//{

//} while(true)


// runs the code 0 or more times
//while(true)
//{

//}




Console.Beep();
Console.ReadKey();
