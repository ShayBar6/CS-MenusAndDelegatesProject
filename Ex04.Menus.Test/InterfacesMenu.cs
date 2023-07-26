using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    // $G$ CSS-999 (-3) The Class must have an access modifier.
    static class InterfacesMenu
    {
        // $G$ CSS-011 (-5) Public / protected method should start with an Upper case letter.
        public static void buildMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");
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

            ItemDate.AddListener(new CurrentDateMenuItem());
            ItemTime.AddListener(new CurrentTimeMenuItem());
            ItemVersion.AddListener(new VersionMenuItem());
            ItemCountSpaces.AddListener(new CountSpacesMenuItem());

            mainMenu.Show();
        }
    }
}


