using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu
    {

        private const string k_Separation = "------------------------";

        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();

        private string m_Title;
        private string m_ExitOrBackOption = null;
        private Menu m_PreviousMenu;


        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public string ExitOrBackOption
        {
            get { return m_ExitOrBackOption; }
            set { m_ExitOrBackOption = value; }
        }

        public Menu PreviousMenu
        {
            get { return m_PreviousMenu; }
            set { m_PreviousMenu = value; }
        }

        public void AddMenuItem(MenuItem i_Item)
        {
            if(r_MenuItems != null)
            {
                r_MenuItems.Add(i_Item);
            }
        }

        public void RemoveMenuItem(MenuItem i_Item)
        {
            if(r_MenuItems != null)
            {
                r_MenuItems.Remove(i_Item);
            }
        }

        public void Show()
        {
            int inputFromUser = 0;

            while(true)
            {
                ShowTitle();
                Console.WriteLine(k_Separation);

                for(int i = 1; i <= r_MenuItems.Count; i++)
                {
                    Console.WriteLine(String.Format("{0} -> {1}", i, (r_MenuItems[i - 1]).ToString()));
                }

                Console.WriteLine(String.Format("{0} -> {1}", 0, m_ExitOrBackOption, "\n"));
                Console.WriteLine(k_Separation);

                try
                {
                    inputFromUser = GetUserInputAndCheckIfValid();
                }

                catch(ArgumentException i_Aex)
                {
                    Console.WriteLine(i_Aex.Message);
                    continue;
                }

                catch(FormatException i_Fex)
                {
                    Console.WriteLine(i_Fex.Message);
                    continue;
                }

                break;
            }

            NavigateToNextMenuLevel(inputFromUser);
        }

        public void NavigateToNextMenuLevel(int i_Input)
        {
            Console.Clear();

            // $G$ CSS-003 (-3) The structure of "if" block is not as required, don't use blank lines between if/elseif/else!
            if(i_Input == 0)
            {
                if(PreviousMenu != null)
                {
                    PreviousMenu.Show();
                }
            }

            else if(MenuItems[i_Input - 1].MenuItems.Count > 0)
            {
                MenuItems[i_Input - 1].Show();
            }

            else
            {
                MenuItems[i_Input - 1].NotifyAllListeners();
                Show();
            }
        }

        public void ShowTitle()
        {
            Console.WriteLine(String.Format("**{0}**", m_Title));
        }

        public void EnterYourRequest()
        {
            Console.WriteLine(String.Format("Enter your request: ({0} to {1} or press '0' to {2}.)", 1, r_MenuItems.Count, m_ExitOrBackOption));
        }

        // $G$ SFN-006 (-5) The "Input handling" should have managed by the Menus.Test project.
        public int GetUserInputAndCheckIfValid()
        {
            int answer;

            if(!(int.TryParse(Console.ReadLine(), out answer)))
            {
                throw new FormatException("Invalid Input!");
            }

            else if(answer < 0 || answer > r_MenuItems.Count)
            {
                throw new ArgumentException("Invalid Input!");
            }

            else
            {
                return answer;
            }
        }
    }
}
