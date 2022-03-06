

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "not a human";
lookup["fish"] = "not a human that swims";
lookup["human"] = "Us";
Console.WriteLine($"the definition of fish is {lookup["fish"]}");




Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Tim Corey";
employees[28] = "Sue Storm";


Console.WriteLine($"the employee with id number 28 is {employees[28]}");


Console.Beep();
Console.ReadKey();
