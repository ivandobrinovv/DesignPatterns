using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    class MenuFacade
    {
        static readonly AdminMenu _adminMenu = new AdminMenu();
        static readonly UserMenu _userMenu = new UserMenu();
        static readonly GuestMenu _guestMenu = new GuestMenu();

        public static List<MenuItem> GetAdminMenu()
        {
            return _adminMenu.GetAdminMenuItems().Concat(GetUserMenu()).ToList();
        }

        public static List<MenuItem> GetUserMenu()
        {
            return _userMenu.GetUserMenuItems().Concat(GetGuestMenu()).ToList();
        }

        public static List<MenuItem> GetGuestMenu()
        {
            return _guestMenu.GetGuestMenuItems();
        }
    }
}
