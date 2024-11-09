namespace BirthdayCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime date;

            Console.Write("Enter your birth date (DD/MM/YYYY): ");

            DateTime.TryParse(Console.ReadLine(), out date);

            DateTime nextBDay = Convert.ToDateTime(date.AddYears(today.Year - date.Year + 1));
            int daysLeft = nextBDay.Subtract(today).Days;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0} days till your birthday!!! ({1})", daysLeft, nextBDay.ToLongDateString());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
    }
}