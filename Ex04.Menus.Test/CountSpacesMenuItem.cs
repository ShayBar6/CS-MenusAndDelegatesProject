using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class CountSpacesMenuItem : IMenuItemChosenListener
    {
        void IMenuItemChosenListener.ReportMenuItemChosen()
        {
            displayCountSpaces();
        }

        private void displayCountSpaces()
        {
            string input;
            Console.WriteLine("Please enter your sentence:");
            input = Console.ReadLine();
            Console.WriteLine(String.Format("There are {0} spaces in your sentence.", input.Count(char.IsWhiteSpace)));
        }
    }
}
