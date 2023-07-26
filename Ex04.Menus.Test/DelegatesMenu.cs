using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex04.Menus.Test
{
    static class DelegatesMenu
    {
        public static void buildMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");
            MenuItem ItemDateOrTime = new MenuItem("Show Date/Time", mainMenu);
            MenuItem ItemVersionAndSpaces = new MenuItem("Version And Spaces", mainMenu);

            mainMenu.AddMenuItem(ItemDateOrTime);
            mainMenu.AddMenuItem(ItemVersionAndSpaces);

            MenuItem ItemDate = new MenuItem("Show Date", ItemDateOrTime);
            MenuItem ItemTime = new MenuItem("Show Time", ItemDateOrTime);
            MenuItem ItemVersion = new MenuItem("Show Version", ItemVersionAndSpaces);
            MenuItem ItemCountSpaces = new MenuItem("Count Spaces", ItemVersionAndSpaces);

            ItemDateOrTime.AddMenuItem(ItemDate);
            ItemDateOrTime.AddMenuItem(ItemTime);

            ItemVersionAndSpaces.AddMenuItem(ItemVersion);
            ItemVersionAndSpaces.AddMenuItem(ItemCountSpaces);

            ItemDate.Chosen += displayCurrentDate;
            ItemTime.Chosen += displayCurrentTime;
            ItemVersion.Chosen += displayVersion;
            ItemCountSpaces.Chosen += displayCountSpaces;

            mainMenu.Show();
        }

        // $G$ DSN-004 (-5) Redundant code duplication.
        private static void displayCurrentTime()
        {
            Console.WriteLine(string.Format("The Hour is: {0}", DateTime.Now.ToString("HH:mm")));
        }

        private static void displayCurrentDate()
        {
            Console.WriteLine(string.Format("Today's date is: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")));
        }

        private static void displayCountSpaces()
        {
            string input;
            Console.WriteLine("Please enter your sentence:");
            input = Console.ReadLine();
            Console.WriteLine(String.Format("There are {0} spaces in your sentence.", input.Count(char.IsWhiteSpace)));
        }

        private static void displayVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }
    }
}
