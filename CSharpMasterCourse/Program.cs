
String firstName = String.Empty;
String lastName = String.Empty;
String filePath = String.Empty;

firstName = "Alvin";
lastName = "Yanson";
// just like \n the \ identifies the next character as special
// since it is also a slash, then it will consider as slash
//filePath = "C:\\Temp\\Demo";

// the @ treats the string as string literal characters; gg ez;
filePath = @"C:\Temp\Demo";

String testString = $@"The file for {firstName} is at {filePath}";


Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine($"{filePath}");
Console.WriteLine(testString);

Console.Beep();
Console.ReadKey();