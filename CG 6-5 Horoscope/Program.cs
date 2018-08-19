using System;

namespace CG_6_5_Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the start of the code. Takes in the user's birthday.
            Console.WriteLine("Let's talk horoscopes!!");
            Console.WriteLine("First, provide your birthday in this format - mm/dd/yyyy.");

            //This code allows the user to input the birthday and assigns it to a variable
            DateTime Birthday = DateTime.Parse(Console.ReadLine());

            //This takes the variable, figures out which day of the week the date is, 
            //and then writes the day on the screen
            string Day = Birthday.DayOfWeek.ToString();
            Console.WriteLine($"You were born on a {Day}.");
            Console.WriteLine();

            //This tells the user what day of the week their birthday will fall on next year
            //by using the variable. And then prints it on the screen.
            string DayNext = Birthday.AddYears(1).DayOfWeek.ToString();
            Console.WriteLine($"Your birthday will be on a {DayNext} next year.");
            Console.WriteLine();

            //var Zodiac = Birthday.MonthDayPattern.ToString(); <--this was code trying to convert the inputted date 
            //to make it easer for the if statement -- this one was a no go

            //this converts the variable from DateTime to int to use it in the 'if' statement
            string Zodiac = Birthday.ToString("MMdd");
            int zodiac = Convert.ToInt32(Zodiac);

            //Console.WriteLine(zodiac); <--just a test coding

            //if statement coding to get to the appropriate zodiac sign
            if (321 <= zodiac && zodiac <= 419)
            {
                Console.WriteLine("Your Zodiac sign is Aries.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be much like a roller coaster.");
                Console.WriteLine("Slap on a helmet and make sure you wear you're seatbelt.");
            }
            
            else if (420 <= zodiac && zodiac <= 520)
            {
                Console.WriteLine("Your Zodiac sign is Taurus.");
                Console.WriteLine("Your fortune is --");
                Console.WriteLine("The year ahead will be like a waterfall.");
                Console.WriteLine("Calm and peaceful but don't try it in a barrel.");
            }

            else if (0521 <= zodiac && zodiac <= 0620)
            {
                Console.WriteLine("Your Zodiac sign is Gemini.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be like a game of Where's Waldo.");
                Console.WriteLine("You'll spend far too much time looking for a weird dude in an ugly shirt.");
            }
            
            else if (0621 <= zodiac && zodiac <= 0722)
            {
                Console.WriteLine("Your Zodiac sign is Cancer.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be crazy in the relationship department.");
                Console.WriteLine("Remember to be a crab, not get them.");
            }

            else if (0723 <= zodiac && zodiac <= 0822)
            {
                Console.WriteLine("Your Zodiac sign is Leo.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be a year about learning to let go.");
                Console.WriteLine("Prop the feet up and do something that rots the brain a bit.");
            }

            else if (0823 <= zodiac && zodiac <= 0922)
            {
                Console.WriteLine("Your Zodiac sign is Virgo.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be earth shattering.");
                Console.WriteLine("Be sure to pack extra underwear and tons of glue.");
            }

            else if (0923 <= zodiac && zodiac <= 1022)
            {
                Console.WriteLine("Your Zodiac sign is Libra.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be one on infamy.");
                Console.WriteLine("Get out there and shake your tail feathers.");
            }

            else if (1023 <= zodiac && zodiac <= 1121)
            {
                Console.WriteLine("Your Zodiac sign is Scorpio.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be one of growing.");
                Console.WriteLine("It takes a big person to admit they're wrong, but you're still");
                Console.WriteLine("in the juniors department.  Let's hope you figure that out quick.");
            }

            else if (1122 <= zodiac && zodiac <= 1221)
            {
                Console.WriteLine("Your Zodiac sign is Sagittarius.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be a lot like a deer hunt.");
                Console.WriteLine("Shoot it dead and cook it up into something nummy.");
            }

            else if (1222 <= zodiac && zodiac <= 119)
            {
                Console.WriteLine("Your Zodiac sign is Capricorn.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will be like a gingerbread house in the woods.");
                Console.WriteLine("An amazing sweet surprise where you will either die or");
                Console.WriteLine("push an old woman into an oven.");
            }

            else if (120 <= zodiac && zodiac <= 218)
            {
                Console.WriteLine("Your Zodiac sign is Aquarius.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will have the moon in the seventh house.");
                Console.WriteLine("And Jupiter aligns with Mars. Peace will guide the planets.");
                Console.WriteLine("And love will steer the stars. It's the dawning of the age.");
            }

            else if (219 <= zodiac && zodiac <= 320)
            {
                Console.WriteLine("Your Zodiac sign is Pisces.");
                Console.WriteLine("Your fortune is -- ");
                Console.WriteLine("The year ahead will a good time to go fishing.");
                Console.WriteLine("Remember catch and release is the policy to life.");
            }

            else
            {
                Console.WriteLine("I'm sorry. We didn't understand any of that nonsense you just put in.");
            }

    

            Console.ReadLine();

           
        }
    }
}
