using System;

namespace Voxel_Technical_Interview___SnakesAndLadders
{
    public class SnakesAndLaddersPrincipal
    {
        private int menuOption;
        private Token playerOne;
        private Token playerTwo;

        public void RunPrincipalActivity()
        {
            GenerateMainMenu();

            switch (menuOption)
            {
                case 1:
                    Console.WriteLine("Game started!\n");
                    StartGame();
                    PrintPositions();
                    break;
                default:
                    Console.WriteLine("Activity not registered, please try again.\n");
                    GenerateMainMenu();
                    break;
            }
        }

        private int GenerateMainMenu()
        {
            Console.WriteLine("Welcome to Snakes and Ladders.\n");
            Console.WriteLine("This game will be played by two players.\n");

            Console.WriteLine("To start to play, please select the number of an option:\n");
            Console.WriteLine("1-Start the game");
            Console.WriteLine("9-Close game");

            int.TryParse(Console.ReadLine(), out menuOption);

            return menuOption;
        }

        private void StartGame()
        {
            playerOne = new Token()
            {
                Name = "Player One",
                Position = 1
            };

            playerTwo = new Token()
            {
                Name = "Player Two",
                Position = 1
            };
        }

        private void PrintPositions()
        {
            Console.WriteLine($"{playerOne.Name} position: {playerOne.Position}");
            Console.WriteLine($"{playerTwo.Name} position: {playerTwo.Position}\n");
        }

        private int GeneratePosition()
        {

        }
    }
}