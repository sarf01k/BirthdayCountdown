DateTime today = DateTime.Today;
DateTime date;

Console.Write("Enter your birth date: ");

if (DateTime.TryParse(Console.ReadLine(), out date))
{
    if (date > today)
    {
        Console.WriteLine("The date entered is in the future. Please enter a valid date.");
        return;
    }    
}
else
{
    Console.WriteLine("Enter a valid date.");
    return;
}

DateTime nextBDay = Convert.ToDateTime(date.AddYears(today.Year - date.Year + 1));
int daysLeft = nextBDay.Subtract(today).Days;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n{daysLeft} days till your birthday!!! ({nextBDay.ToLongDateString()})");
Console.ForegroundColor = ConsoleColor.Gray;
Console.ReadLine();