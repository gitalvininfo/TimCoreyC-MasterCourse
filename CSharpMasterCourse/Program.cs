

DateTime today = DateTime.Now;

// 
DateOnly birthday = DateOnly.Parse("6/11/1998");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));


Console.WriteLine("Today full: " + today); // 05/03/2022 4:21:00 pm
Console.WriteLine("Today just date: " + today.Date); // 05/03/2022 12:00:00 am
Console.WriteLine("Birthday full: " + birthday); // 06/11/1998

Console.Beep();
Console.ReadKey();
