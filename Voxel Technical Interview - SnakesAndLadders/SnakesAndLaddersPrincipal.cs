using System;

namespace Voxel_Technical_Interview___SnakesAndLadders
{
    public class SnakesAndLaddersPrincipal
    {
        private int menuOption;
        private Token playerOne;
        private Token playerTwo;
        private readonly Random rnd = new Random();
        private void RunPrincipalActivity()
        {
            GenerateSubMenu();

            switch (menuOption)
            {
                case 1:
                    Console.WriteLine("Game started!\n");
                    StartGame();
                    PrintPositions();
                    RunPrincipalActivity();
                    break;
                case 2:
                    MoveToken();
                    break;
                case 3:
                    PrintPositions();
                    RunPrincipalActivity();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Activity not registered, please try again.\n");
                    RunPrincipalActivity();
                    break;
            }
        }

        public void GenerateMainMenu()
        {
            Console.WriteLine("Welcome to Snakes and Ladders.\n");
            Console.WriteLine("This game will be played by two players.\n");

            RunPrincipalActivity();
        }

        private int GenerateSubMenu()
        {
            Console.WriteLine("To start to play, please select the number of an option:\n");
            Console.WriteLine("1-Start/restart the game");
            Console.WriteLine("2-Move Token");
            Console.WriteLine("3-Pint positions");
            Console.WriteLine("9-Close game\n");

            int.TryParse(Console.ReadLine(), out menuOption);

            return menuOption;
        }

        private void StartGame()
        {
            playerOne = new Token()
            {
                Name = "Player One",
                Position = 1,
                Turn = true
            };

            playerTwo = new Token()
            {
                Name = "Player Two",
                Position = 1,
                Turn = false
            };
        }

        private void PrintPositions()
        {
            if (playerOne == null || playerTwo == null)
            {
                Console.WriteLine("First, you have to start the game.\n");
                RunPrincipalActivity();
            }
            else
            {
                Console.WriteLine($"{playerOne.Name} position: {playerOne.Position}");
                Console.WriteLine($"{playerTwo.Name} position: {playerTwo.Position}\n");
            }           
        }

        private void MoveToken()
        {            
            int dice = rnd.Next(1, 7);
            Console.WriteLine("Rolling the die ...");
            Console.WriteLine($"Die number is {dice}");


            if (playerOne == null || playerTwo == null)
            {
                Console.WriteLine("First, you have to start the game.\n");
                RunPrincipalActivity();
            }
            else
            {
                if (playerOne.Turn)
                {
                    Console.WriteLine($"{playerOne.Name} is playing now.");
                    if ((playerOne.Position + dice) <= 100)
                        playerOne.Position += dice;
                    VerifyPosition(playerOne);
                    Console.WriteLine($"Now, the position of {playerOne.Name} is {playerOne.Position}.\n");
                    playerOne.Turn = false;
                    playerTwo.Turn = true;
                    RunPrincipalActivity();
                }
                else
                {
                    Console.WriteLine($"{playerTwo.Name} is playing now.");
                    if ((playerTwo.Position + dice) <= 100)
                        playerTwo.Position += dice;
                    VerifyPosition(playerTwo);
                    Console.WriteLine($"Now, the position of {playerTwo.Name} is {playerTwo.Position}.\n");
                    playerTwo.Turn = false;
                    playerOne.Turn = true;
                    RunPrincipalActivity();
                }
            }           
        }

        private void VerifyPosition(Token player)
        {
            if (player.Position == 100)
            {
                Console.WriteLine($"Congratulation {player.Name}, you are the winner!\n The game will close.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}