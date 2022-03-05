
//string[] firstnames = new string[5];

//firstnames[0] = "alvin1";
//firstnames[1] = "alvin2";
//firstnames[2] = "alvin3";
//firstnames[3] = "alvin4";
//firstnames[4] = "alvin5";
//firstnames[5] = "alvin";


//foreach (string firstname in firstnames) {
//    Console.WriteLine(firstname);
//}


string data = "Tim,Sue,Bob,Jane,Frank";

string[] firstNames = data.Split(",");

foreach (string firstname in firstNames)
{
    Console.Write($"{firstname}, ");

}

Console.WriteLine();

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

foreach (string lastname in lastNames)
{
    Console.Write($"{lastname}, ");
}



Console.Beep();
Console.ReadKey();
