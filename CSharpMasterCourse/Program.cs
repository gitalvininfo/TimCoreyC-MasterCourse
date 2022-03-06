

using CSharpMasterCourse;


string name = ConsoleMessages.GetUsersName();

ConsoleMessages.SayHi(name);
ConsoleMessages.SayGoodbye();

double result = MathShortcuts.Add(3, 5);
Console.WriteLine(result);

double[] vals = { 2, 5, 6, 21, 52, 98 };

MathShortcuts.AddAll(vals);

Console.Beep();
Console.ReadKey();
