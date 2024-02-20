using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AnsiConsole.Write(
                new FigletText("Guess Number")
                .Centered()
                .Color(Color.Blue)
                );


            string menuOption = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("  Game Options")
                .PageSize(10)
                .AddChoices(new[] {
                    "Start Game", "Help", "Exit",
                }));


            switch (menuOption)
            {
                case "Start Game":
                    new GuessNumber().StartGame();
                    
                    break;
                case "Help":
                    var rule = new Rule("[green1]Instructions[/]");
                    rule.Style = Style.Parse("lime");
                    AnsiConsole.Write(rule);

                    AnsiConsole.WriteLine(" The value of x must be discovered using simple mathematics");
                    AnsiConsole.WriteLine(" You need to take the total value (90) and add it to the value of the second operand (43)");
                    AnsiConsole.WriteLine(" Example: X - 43 = 90");
                    AnsiConsole.WriteLine(" R: 113");
                    AnsiConsole.WriteLine(" 113 - 43 = 90");
                    AnsiConsole.Write(rule);

                    string option = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("")
                        .PageSize(10)
                        .AddChoices(new[] {
                            "OK", "Exit",
                        }));

                    break;

                case "Exit":

                break;
                   
            }



        }
    }
}
