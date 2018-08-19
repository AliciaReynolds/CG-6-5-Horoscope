using System;

namespace CG_6_5_Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's talk horoscopes!!");
            Console.WriteLine("First, provide your birthday in this format - mm/dd/yyyy.");

            DateTime Birthday = DateTime.Parse(Console.ReadLine());
            string Day = Birthday.DayOfWeek.ToString();
            Console.WriteLine($"You were born on a {Day}.");

        }
    }
}
