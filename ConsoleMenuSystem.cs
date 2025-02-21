using System.Collections.Generic;

namespace Delegate_and_Reflection
{
    public delegate void MenuAction();
    internal class ConsoleMenuSystem
    {
        public static void ShowDate()
        {
            Console.WriteLine("Current Date: "+ DateTime.Now.ToShortDateString());
        }

        public static void ShowTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToShortTimeString());
        }

        public static void Exit()
        {
            Console.WriteLine("Exiting the application...");
        }

        public static void Show()
        {
            Dictionary<string, MenuAction> menu = new Dictionary<string, MenuAction>
            {
                {"1", ShowDate},
                {"2", ShowTime},
                {"3", Exit}
            };

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Show Date");
                Console.WriteLine("2. Show Time");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (menu.ContainsKey(choice))
                {
                    menu[choice]();
                    if (choice == "3") break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

        }
    }
}
