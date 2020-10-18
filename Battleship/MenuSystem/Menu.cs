using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuSystem
{
    public enum MenuLevel
    {
        FirstWhetherReady, //0
        SecondGameMode //1
    }

    public class Menu
    {
        private static string EXIT_CODE = "x";
        private Dictionary<string, MenuItem> MenuItems { get; set; } = new Dictionary<string, MenuItem>();
        private readonly MenuLevel _menuLevel;

        public Menu(MenuLevel menuLevel)
        {
            _menuLevel = menuLevel; 
        }

        public void AddMenuItem(MenuItem item)
        {
            if (item.OptionLabelToChoose == "")
            {
                throw new Exception("User choice cannot be empty");
            }
            
            MenuItems.Add(item.OptionLabelToChoose, item);
        }

        public void RunMenu()
        {
            var userChoice = "";
            
            do
            {
                Console.WriteLine("");
                //displaying the menu
                foreach (var menuItem in MenuItems)
                {
                    Console.WriteLine(menuItem.Value); //ToString is overriden so we see a nice output here
                }

                switch (_menuLevel)
                {
                    case MenuLevel.FirstWhetherReady:
                        Console.WriteLine("x) eXit");
                        break;
                    case MenuLevel.SecondGameMode:
                        Console.WriteLine("r) Return to main");
                        Console.WriteLine("x) eXit");
                        break;
                    default:
                        throw new Exception("Unknown location");
                }
                
                Console.Write(">");
                //handling user choice
                userChoice = Console.ReadLine()?.ToLower().Trim() ?? "";
                if (userChoice == EXIT_CODE)
                {
                    Console.WriteLine("Closing Down...");
                    break;
                } 

                //return userChosenMenuItem and boolean (whether item associated with the given key was found or not) + pass value of found entru into userChosenItem
                if (MenuItems.TryGetValue(userChoice, out var userChosenMenuItem))
                {
                        userChosenMenuItem.OptionToExecute();
                } else {
                    Console.WriteLine("I don't have this option ");
                }
            } while (userChoice != EXIT_CODE);
        }
    }
}