using TryActions;

PrintHeader();
GetNewData(() => DataGenerator.GetGuid());

void PrintHeader()
{
    Console.ForegroundColor = Constants.Colors.Highlight;
    Console.WriteLine("This is sample");
}

void GetNewData(Func<string> method)
{
    Console.WriteLine();
    Console.ForegroundColor = Constants.Colors.Shadow;
    Console.Write("Generated value: ");
    Console.ForegroundColor = Constants.Colors.Value;
    Console.WriteLine(method.Invoke());
    Console.ForegroundColor = Constants.Colors.Shadow;
}

