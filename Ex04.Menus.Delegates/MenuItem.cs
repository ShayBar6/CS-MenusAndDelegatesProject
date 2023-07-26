using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : Menu
    {
        public event Action Chosen;
    
        
        public MenuItem(string i_Title, Menu i_PreviousMenu = null)
        {
            Title = i_Title;
            PreviousMenu = i_PreviousMenu;
            ExitOrBackOption = "Back";
        }

        public override string ToString()
        {
            return Title;
        }

        public void OnChosen()
        {
            if (Chosen != null)
            {
                Chosen.Invoke();
            }
        }
    }
}
