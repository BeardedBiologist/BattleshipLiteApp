using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary.Models;

namespace BattleshipLite
{
    class Program
    {
       
        static void Main(string[] args)
        {
            WelcomeMessage();
            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Joshua James");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            // Ask user for their name
            output.UsersName = AskForUsersName();
            // Load up the shot grid
            output.ShotGrid = 
            // Ask the user for their 5 ship placements 
            // Clear

        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}