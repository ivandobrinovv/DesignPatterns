using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    class UserMenu
    {
        internal List<MenuItem> GetUserMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem
                {
                    ItemText = "UserMenuItem1",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            ItemText = "UserSubMenuItem11"
                        },

                        new MenuItem
                        {
                            ItemText = "UserSubMenuItem12"
                        }
                    }
                },

                new MenuItem
                {
                    ItemText = "UserMenuItem2",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            ItemText = "UserSubMenuItem21"
                        },

                        new MenuItem
                        {
                            ItemText = "UserSubMenuItem22"
                        }
                    }
                }
            };
        }
    }
}
