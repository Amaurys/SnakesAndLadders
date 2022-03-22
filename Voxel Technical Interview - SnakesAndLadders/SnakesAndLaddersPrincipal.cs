using System;

namespace Voxel_Technical_Interview___SnakesAndLadders
{
    public class SnakesAndLaddersPrincipal
    {
        private int menuOption;

        public void PrincipalActivity()
        {
            MainMenu();



            switch (menuOption)
            {
                case 1:  

                default: 
                    Console.WriteLine("Activity not registered, please try again.");
                    break;
            }
        }

        private int MainMenu()
        {
            Console.WriteLine("Welcome to Snakes and Ladders.\n");

            Console.WriteLine("To start to play, please select the number of an option:\n");
            Console.WriteLine("1-Start the game");
            Console.WriteLine("0-Close game");

            int.TryParse(Console.ReadLine(), out menuOption);

            return menuOption;
        }
    }
}