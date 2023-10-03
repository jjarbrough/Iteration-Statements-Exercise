namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void CountDown()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool Equal(int a, int b)
        {
            return a == b;
        }
        //Write a method to check whether a given number is even or odd
        public static string EvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }

        }
        //Write a method to check whether a given number is positive or negative
        public static string PosNeg(int num)
        {
            if (num < 0)
            {
                return "Negative";
            }
            else
            {
                return "Positive";
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You can't vote yet. Try back later");
            }
            else
            {
                Console.WriteLine("Good to go. You can vote!");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static string InRange(int number)
        {
            if (number < -10 || number > 10)
            {
                return "not between -10 and 10";
            }
            else
            {
                return "It is between -10 and 10! Good job!";
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int num)
        {
            string returnString = "";
            for (int i = 1; i<= 12; i++)
            {
                 Console.WriteLine(i * num);
            }   
         
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            CountDown();
            ByThree();
            Console.WriteLine(Equal(5, 5));
            Console.WriteLine(EvenOdd(10));
            Console.WriteLine(PosNeg(-50));
            Console.WriteLine("Enter your age, See if you can vote");
            var voteInput = int.Parse(Console.ReadLine());
            CanVote(voteInput); 
            Console.WriteLine("Enter a number, see if its between -10 and 10");
            var rangeInput = int.Parse(Console.ReadLine());
            Console.WriteLine(InRange(rangeInput));
            MultTable(5);
        }
    }
}
