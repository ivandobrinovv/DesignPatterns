using CourseProject.Enums;
using CourseProject.Helpers;
using CourseProject.Menu;
using CourseProject.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                SessionHelper currentSession = SessionHelper.GetCurrentSession();

                MenuHelper.AuthenticateUserMenu();

                MenuItemAggregate menuItems = MenuHelper.GetMenuItemsForCurrentUser();

                do
                {
                    MenuHelper.PrintMenu(menuItems, out int choice);
                    if (choice == 0)
                    {
                        currentSession.Logout();
                        break;
                    }
                    if (choice == -1)
                    {
                        return;
                    }
                    menuItems = new MenuItemAggregate(menuItems[choice].SubItems);
                } while (true);
            } while (true);
        }
    }
}
