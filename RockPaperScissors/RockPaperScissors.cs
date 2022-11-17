using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main()
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose between [r]ock, [p]aper or [s]cissors: ");
            string playerChoice = Console.ReadLine();

            if (playerChoice == "r" || playerChoice == "rock")
            {
                playerChoice = Rock;
            }
            else if (playerChoice == "p" || playerChoice == "paper")
            {
                playerChoice = Paper;
            }
            else if (playerChoice == "s" || playerChoice == "scissors")
            {
                playerChoice = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }

            Random rand = new Random();
            int randomNumber = rand.Next(1, 4);

            string computerChoice = string.Empty;

            switch (randomNumber)
            {
                case 1:
                    computerChoice = Rock;
                    break;
                case 2:
                    computerChoice = Paper;
                    break;
                case 3:
                    computerChoice = Scissors;
                    break;
            }

            if ((playerChoice == Rock && computerChoice == Scissors)||
                (playerChoice == Paper && computerChoice == Rock)||
                (playerChoice == Scissors && computerChoice == Paper))
            {
                Console.WriteLine("You win.");
            }
            if ((playerChoice == Rock && computerChoice == Paper) ||
                (playerChoice == Paper && computerChoice == Scissors) ||
                (playerChoice == Scissors && computerChoice == Rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game is draw.");
            }
        }
    }
}
