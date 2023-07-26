using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class VersionMenuItem : IMenuItemChosenListener
    {
        // $G$ CSS-999 (-3) The method must have an access modifier, even if it is an implementation of interface.
        void IMenuItemChosenListener.ReportMenuItemChosen()
        {
            displayVersion();
        }

        private static void displayVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }
    }
}
