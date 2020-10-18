using System;
using System.Collections.Generic;
using System.Text;
using BattleShipConsoleUI;
using MenuSystem;
using GameLogic;
namespace BattleshipConsoleApp
{
    class ProgramMain
    {
       
        static void Main()
        {
            var userChoice = "";
            var menuALevel = new Menu(MenuLevel.FirstWhetherReady);
            var menuBLevel = new Menu(MenuLevel.SecondGameMode);

            BattleShipConsoleUi.board1 = new GameBoard(10, 10);

            Console.WriteLine("<========== USELESS BATTLESHIP ==========>");
            Console.WriteLine("Welcome to the 'Pointless Battleship!'");
            Console.WriteLine("The most useless game you ever played!");
            Console.WriteLine("");
            Console.WriteLine("Are you ready? (y/n)");
            Console.WriteLine("");

            menuBLevel.AddMenuItem(new MenuItem("1", "Start Game", StartGame));
            menuBLevel.AddMenuItem(new MenuItem("2", "Continue previous game", DefaultMenuAction));
            menuALevel.AddMenuItem(new MenuItem("y", "Yes", menuBLevel.RunMenu));
            menuALevel.AddMenuItem(new MenuItem("n", "No", ClosingDown));
            menuALevel.RunMenu();

            //TODO: add menu for choosing ship option 

        }
            
        static void StartGame()
        {
            int width, heigh;
            Console.WriteLine("Enter width of the board");
            Console.Write(">");
            while(int.TryParse(Console.ReadLine(), out width) == false)
            {
                Console.WriteLine("Enter correct number");
            }
            Console.WriteLine("Enter height of the board");
            Console.Write(">");
            while (int.TryParse(Console.ReadLine(), out heigh) == false)
            {
                Console.WriteLine("Enter correct number");
            }
            GameHandler.StartGame(width, heigh, true);
        }
        static void DefaultMenuAction()
        {
            Console.WriteLine("Action! (Not implemented yet tho)");
        }

        static void ClosingDown()
        {
            Console.WriteLine("Bye Bye");
        }

        static void LoadGameState()
        {
            //TODO write and implement body of the method
        }

        static void SaveGameState()
        {
            //TODO write and implement body of the method
        }            
    }
}
