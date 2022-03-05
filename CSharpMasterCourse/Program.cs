

string firstName = "alvin";
int age = 24;

switch(age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;

    case >= 18 and < 99:
        Console.WriteLine("You should have a job ");
        break;

    case >= 66:
        Console.WriteLine("Retire now");
        break;

    default:
        Console.WriteLine("age was not in expected range");
        break;

}


//switch(firstName)
//{
//    case "alvin":
//        Console.WriteLine("Hello alvin");
//        break;

//    case "tom":
//        Console.WriteLine("Hello tom");
//        break;

//    default:
//        Console.WriteLine("Sorry I dont know you.");
//        break;
//}

















Console.Beep();
Console.ReadKey();
