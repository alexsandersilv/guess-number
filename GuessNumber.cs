using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class GuessNumber
    {

        static int x, y, z;

        static Random rng = new Random();

        public static void StartGame()
        {
            GenerateGandomNumbers();
            ShowCalc();
            InputControll.HandleUserResponse();
        }

        public static void Banner()
        {
            Console.WriteLine("   ______                        _   __                __             " +
                "\n  / ____/_  _____  __________   / | / /_  ______ ___  / /_  ___  _____" +
                "\n / / __/ / / / _ \\/ ___/ ___/  /  |/ / / / / __ `__ \\/ __ \\/ _ \\/ ___/" +
                "\n/ /_/ / /_/ /  __(__  |__  )  / /|  / /_/ / / / / / / /_/ /  __/ /    " +
                "\n\\____/\\__,_/\\___/____/____/  /_/ |_/\\__,_/_/ /_/ /_/_.___/\\___/_/");
            Console.WriteLine("Options:\n1-Start Game\n2-Help");
        }

        public static void Help()
        {
            Console.WriteLine("\n=======================================================================================");
            Console.WriteLine("The value of x must be discovered using simple mathematics");
            Console.WriteLine("Example:");
            Console.WriteLine("     X - 43 = 90");
            Console.WriteLine("");
            Console.WriteLine("You need to take the total value (90) and add it to the value of the second operand (43)");
            Console.WriteLine("R: 113");
            Console.WriteLine("113 - 43 = 90");
        }

        public static void GenerateGandomNumbers()
        {
            x = rng.Next(999);
            y = rng.Next(999);
            GetValueTotal();
        }

        static void GetValueTotal()
        {
            z = x + y;
        }


        public static void ShowCalc()
        {
            Console.WriteLine($"X - {y} = {z}");
        }

        public static void HandleResponse(int userResponse)
        {
            if (userResponse == x)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("For now that's it (=");
            }
            else 
            {
                Console.WriteLine("Incorrect");
                Console.WriteLine("Try again");
                InputControll.HandleUserResponse();

            }
        }
    }
}
