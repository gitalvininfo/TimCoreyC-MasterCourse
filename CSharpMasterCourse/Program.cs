


//string data = "Tom,Frank,Sue,Tim,Jones";

//List<string> names = data.Split(",").ToList();


//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}


List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(23.78M);
charges.Add(23.78M);

decimal total = 0;

for(int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Total is: {total}");



Console.Beep();
Console.ReadKey();
