using CourseProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Helpers
{
    public class SessionHelper
    {
        public UserRoles Role { get; private set; }
        public bool IsAdministrator { get; private set; }
        public bool IsAuthenticated { get; private set; }

        private static SessionHelper CurrentSession { get; set; }

        private SessionHelper()
        {

        }

        public static SessionHelper GetCurrentSession()
        {
            if (CurrentSession == null)
            {
                CurrentSession = new SessionHelper();
            }
            return CurrentSession;
        }

        public void SetSession(UserRoles role)
        {
            Role = role;
            IsAdministrator = role == UserRoles.Administrator;
            IsAuthenticated = true;
        }

        public void Logout()
        {
            Role = UserRoles.Guest;
            IsAdministrator = false;
            IsAuthenticated = false;
        }
    }
}
