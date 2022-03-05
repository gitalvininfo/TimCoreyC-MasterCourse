


Console.Write("What is your age: ");
string ageText = Console.ReadLine();

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"this is valid: {isValidInt}. The number was {age}.");

Console.WriteLine("Your age is " + age);


double testDouble = age;

decimal testDecimal = (decimal)testDouble;



Console.WriteLine(testDecimal);
 


















//bool isContinue = true;


//while (isContinue)
//{
//    try
//    {
//        Console.Write("What is your age:  ");
//        int age = Convert.ToInt32(Console.ReadLine());

//        isContinue = true;

//        age += 15;

//        Console.WriteLine($"Your age plus 15 is {age}");

//        Console.WriteLine("Do you want to continue? Y/N");

//        if(Console.ReadLine() == "Y") 
//        {
//            isContinue = true;
//        }   else
//        {
//            isContinue = false;
//        }
//    } catch (FormatException e)
//    {
//        Console.WriteLine("Enter only numbers pls.");
//        continue;
//    }
//}


Console.Beep();
Console.ReadKey();
