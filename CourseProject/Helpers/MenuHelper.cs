using CourseProject.Enums;
using CourseProject.Menu;
using CourseProject.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Helpers
{
    public class MenuHelper
    {
        static SessionHelper currentSession = SessionHelper.GetCurrentSession();

        /// <summary>
        /// Prints all existing roles numbered as in the enum
        /// until the user chooses a valid one, when he does
        /// the method creates session for the user.
        /// Clears the console on each print of the roles list.
        /// </summary>
        /// <param name="currentSession">Session object representing the existing session</param>
        public static void AuthenticateUserMenu()
        {
            do {
                int choice;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please choose your role:");
                    string[] roleNames = Enum.GetNames(typeof(UserRoles));

                    for (int i = 0; i < roleNames.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}.{roleNames[i]}");
                    }
                }
                while (!int.TryParse(Console.ReadLine(), out choice)
                            || !Enum.IsDefined(typeof(UserRoles), choice));

                    currentSession.SetSession((UserRoles)choice);

            } while (!currentSession.IsAuthenticated);
        }

        public static MenuItemAggregate GetMenuItemsForCurrentUser()
        {
            MenuItemAggregate menuItems = new MenuItemAggregate();

            switch (currentSession.Role)
            {
                case UserRoles.Administrator:
                    menuItems = new MenuItemAggregate(MenuFacade.GetAdminMenu());
                    break;
                case UserRoles.User:
                    menuItems = new MenuItemAggregate(MenuFacade.GetUserMenu());
                    break;
                case UserRoles.Guest:
                    menuItems = new MenuItemAggregate(MenuFacade.GetGuestMenu());
                    break;
                default:
                    throw new NotImplementedException();
            }

            return menuItems;
        }

        public static void PrintMenu(MenuItemAggregate menuItems, out int choice)
        {
            if(menuItems.Count == 0)
            {
                Console.WriteLine("Something went wrong! Please contact the system administrator!");
                choice = -1;
                return;
            }

            IMenuItemIterator iter = menuItems.GetIterator();
            do
            {
                Console.Clear();

                for (MenuItem s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
                {
                    Console.WriteLine($"{iter.CurrentIndex + 1}.{s.ItemText}");
                }

                Console.WriteLine("\n0.Logout");
            } while (!int.TryParse(Console.ReadLine(), out choice)
                            || menuItems.Count < choice || choice < 0);
        }
    }
}
