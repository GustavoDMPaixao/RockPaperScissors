using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;

            while (playAgain)
            {
                player = "";
                computer = "";
                
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine().ToUpper();
                }
                int randomNumber = random.Next(1, 4);
                switch (randomNumber)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");
            }

            Console.ReadKey();
        }
    }
}