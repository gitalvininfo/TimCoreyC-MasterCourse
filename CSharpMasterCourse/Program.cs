

Console.Write("Hi user! What is your age? ");
string ageText = Console.ReadLine();

bool isValidAge = int.TryParse(ageText, out int age);

int targetYear = 25;

Console.WriteLine($"Your age is:  {age}");
Console.WriteLine($"Your age in {targetYear} years is {age + targetYear}");
Console.WriteLine($"Your age {targetYear} years ago is {age - targetYear}");

Console.Beep();
Console.ReadKey();
