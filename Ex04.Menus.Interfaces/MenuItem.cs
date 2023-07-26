using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{

    public class MenuItem : Menu
    {

        private List<IMenuItemChosenListener> m_MenuItemsChosenListeners = null;


        // $G$ CSS-027 (-3) Unnecessary blank lines.
        public void AddListener(IMenuItemChosenListener listener)
        {
            if (m_MenuItemsChosenListeners == null)
            {
                m_MenuItemsChosenListeners = new List<IMenuItemChosenListener>();
            }

            m_MenuItemsChosenListeners.Add(listener);
        }

        public void RemoveListener(IMenuItemChosenListener listener)
        {
            if (m_MenuItemsChosenListeners != null)
            {
                m_MenuItemsChosenListeners.Remove(listener);
            }
        }

        public void NotifyAllListeners()
        {
            foreach (IMenuItemChosenListener listener in m_MenuItemsChosenListeners)
            {
                listener.ReportMenuItemChosen();
            }
        }

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
    }
}
