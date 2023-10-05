using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class InputControll
    {

        public static void GetUserInputMenu(string message = null)
        {
            if (message == null) 
            {
                Console.Write("Select Option: ");
                int menuOption = InputFilter();
                HandleMenuOption(menuOption);
            }
            else
            {
                Console.Write(message);
                int menuOption = InputFilter();
            }
        }

        private static int InputFilter()
        {
            string optStr = Console.ReadLine();
            if (int.TryParse(optStr, out int optInt))
            {
                return optInt;
            }
            else
            {
                Console.WriteLine("Select a valid option");
                return InputFilter();
            }
        }


        private static void HandleMenuOption(int opt)
        {
            switch (opt)
            {
                case 1:
                    GuessNumber.StartGame();
                    break;
                case 2:
                    GuessNumber.Help();
                    break;
                default:
                    break;
            }
        }

        public static void HandleUserResponse()
        {
            Console.Write("What is the value of X?: ");
            int userResponse = InputFilter();

            GuessNumber.HandleResponse(userResponse);
        }
    }
}
