using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu: Menu
    {
        public MainMenu(string i_Title)
        {
            Title = i_Title;
            ExitOrBackOption = "Exit";
        }
    }
}
