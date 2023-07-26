using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class CurrentTimeMenuItem : IMenuItemChosenListener
    {
        void IMenuItemChosenListener.ReportMenuItemChosen()
        {
            displayCurrentTime();
        }
        private static void displayCurrentTime()
        {
            Console.WriteLine(string.Format("The Hour is: {0}", DateTime.Now.ToString("HH:mm")));
        }
    }
}
