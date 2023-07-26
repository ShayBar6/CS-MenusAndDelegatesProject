using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class CurrentDateMenuItem : IMenuItemChosenListener
    {
        void IMenuItemChosenListener.ReportMenuItemChosen()
        {
            displayCurrentDate();
        }
        private static void displayCurrentDate()
        {
            Console.WriteLine(string.Format("Today's date is: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")));
        }
    }
}
