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
            Console.WriteLine();


            string DayNext = Birthday.AddYears(1).DayOfWeek.ToString();
            Console.WriteLine($"Your birthday will be on a {DayNext} next year.");
            Console.WriteLine();

            //var Zodiac = Birthday.MonthDayPattern.ToString();
            string Zodiac = Birthday.ToString("MMdd");
            int zodiac = Convert.ToInt32(Zodiac);



            if (03/21 <= zodiac && zodiac <= 04/19)
            {
                Console.WriteLine("Your Zodiac sign is Aries.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be much like a roller coaster.");
                Console.WriteLine("Slap on a helmet and make sure you were you're seatbelt.");
            }

            else if (04/20 <= zodiac && zodiac <= 05/20)
            {
                Console.WriteLine("Your Zodiac sign is Taurus.");
                Console.WriteLine("Your fortune is --");
                Console.WriteLine("The year ahead will be like a waterfall.");
                Console.WriteLine("Calm and peaceful but don't try it in a barrel.");
            }

            else if (05/21 <= zodiac && zodiac <= 06/20)
            {
                Console.WriteLine("Your Zodiac sign is Gemini.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be like a game of Where's Waldo.");
                Console.WriteLine("You'll spend far too much time looking for a weird dude in an ugly shirt.");
            }

            else if (06/21 <= zodiac && zodiac <= 07/22)
            {
                Console.WriteLine("Your Zodiac sign is Cancer.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be crazy in the relationship department.");
                Console.WriteLine("Remember to be a crab, not get them.");
            }

            else if (07/23 <= zodiac && zodiac <= 08/22)
            {
                Console.WriteLine("Your Zodiac sign is Leo.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be a year about learning to let go.");
                Console.WriteLine("Prop the feet up and do something that rots the brain a bit.");
            }

            else if (08/23 <= zodiac && zodiac <= 09/22)
            {
                Console.WriteLine("Your Zodiac sign is Virgo.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be earth shattering.");
                Console.WriteLine("Be sure to pack extra underwear and tons of glue.");
            }

            else if (09/23 <= zodiac && zodiac <= 10/22)
            {
                Console.WriteLine("Your Zodiac sign is Libra.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be one on infamy.");
                Console.WriteLine("Get out there and shake your tail feathers.");
            }

            else if (10/23 <= zodiac && zodiac <= 11/21)
            {
                Console.WriteLine("Your Zodiac sign is Scorpio.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be one of growing.");
                Console.WriteLine("It takes a big person to admit they're wrong, but you're still");
                Console.WriteLine("in the juniors department.  Let's hope you figure that out quick.");
            }

            else if (11/22 <= zodiac && zodiac <= 12/21)
            {
                Console.WriteLine("Your Zodiac sign is Sagittarius.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be a lot like a deer hunt.");
                Console.WriteLine("Shoot it dead and cook it up into something nummy.");
            }

            else if (12/22 <= zodiac && zodiac <= 1/19)
            {
                Console.WriteLine("Your Zodiac sign is Capricorn.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be like a gingerbread house in the woods.");
                Console.WriteLine("An amazing sweet surprise where you will either die or");
                Console.WriteLine("push an old woman into an oven.");
            }

            else if (1/20 <= zodiac && zodiac <= 2/18)
            {
                Console.WriteLine("Your Zodiac sign is Aquarius.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will have the moon in the seventh house.");
                Console.WriteLine("And Jupiter aligns with Mars. Peace will guide the planets.");
                Console.WriteLine("And love will steer the stars. It's the dawning of the age.")
            }

            else if (2/19 <= zodiac && zodiac <= 3/20)
            {
                Console.WriteLine("Your Zodiac sign is Pisces.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will a good time to go fishing.");
                Console.WriteLine("Catch and release is the policy to life.");
            }

            else
            {
                Console.WriteLine("I'm sorry. We didn't understand any of that nonsense you just put in.")
            }



            Console.ReadLine();

           
        }
    }
}
