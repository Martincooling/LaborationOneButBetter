using System;
using System.Linq;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser();
            PersonDetails();
            PlayAgain();
        }
        public static void GreetUser()
        {
            Console.WriteLine("Tjena du kommer få skriva in 4 valfria personer och ange deras ålder");
            Console.WriteLine("Tryck på ett knappslag om du vill köra programmet.");
            Console.ReadLine();
        }
        public static void PersonDetails()
        {
            String[] arrayName = new string[4];
            Double[] arrayAge = new Double[4];
            Double[] arrayAgeInDays = new Double[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("What is your name?");
                arrayName[i] = Console.ReadLine();
                Console.WriteLine("What is your age, {0}?",arrayName);
                arrayAge[i] = Double.Parse(Console.ReadLine());
                arrayAgeInDays[i] = arrayAge[i]*365;
            }
            Double SammanLagdÅlder = arrayAge[0] + arrayAge[1] + arrayAge[2] + arrayAge[3];
            Double MedelÅlder = SammanLagdÅlder/4;

            Double biggestNum = arrayAge.Max();
            if (arrayAge[0] == biggestNum)
                Console.WriteLine("\n{0} is the oldest.",arrayName[0]);
            else if (arrayAge[1] == biggestNum)
                Console.WriteLine("\n{0} is the oldest.",arrayName[1]);
            else if (arrayAge[2] == biggestNum)
                Console.WriteLine("\n{0} is the oldest.",arrayName[2]);
            else if (arrayAge[3] == biggestNum)
                Console.WriteLine("\n{0} is the oldest.",arrayName[3]);

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Person {0} heter {1} and is {2} years old and has lived exactly {3} days today.",j+1, arrayName[j],arrayAge[j],arrayAgeInDays[j]);
            }
            Console.WriteLine("Sammanlagda åldern är: {0}", SammanLagdÅlder);
            Console.WriteLine("Medelåldern är: {0:0.00}", MedelÅlder);
        }
        public static void PlayAgain()
        {
            while(true)
            {
                Console.WriteLine("\nVill du spela igen? Klicka på [Y/N]");
                var input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    GreetUser();
                    PersonDetails();
                    break;
                }
                Console.WriteLine("Thanks for playing :)");
                Console.ReadLine();
                break;
            }
        }
    }
}
