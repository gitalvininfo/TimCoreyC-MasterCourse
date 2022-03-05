

using System.Globalization;

DateTime today = DateTime.Now;

//DateTime birthday = DateTime.Parse("08/12/1997");

DateTime birthday = DateTime.ParseExact("08/12/1997", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday);



Console.Beep();
Console.ReadKey();
