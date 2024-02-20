using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class GuessNumber
    {

        Random rng = new Random();
        int x, y, z;

        private void GenerateNumbers()
        {
            x = rng.Next(999);
            y = rng.Next(999);

            z = x + y;
        }

        public void ShowCalc()
        {
            AnsiConsole.MarkupLine($"[yellow1]X - {y} = {z}[/]");
        }

        public void HandleResponse()
        {
            int response = AnsiConsole.Ask<int>("What is the value of [yellow1]X[/]?: ");

            if (response == x)
            {
                AnsiConsole.MarkupLine($"[green]Correct, you got the value of[/] [green1]X ({x})[/] [green]right[/]");
                AnsiConsole.MarkupLine($"[green1]Next level[/]");

                StartGame();
            }
            else
            {
                AnsiConsole.MarkupLine("[red1]Incorrect answer[/]");
                HandleResponse();
            }
        }

        public void StartGame()
        {
            GenerateNumbers();
            ShowCalc();
            HandleResponse();
        }


    }
}
