using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    class AdminMenu
    {
        internal List<MenuItem> GetAdminMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem
                {
                    ItemText = "AdminMenuItem1",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            ItemText = "AdminSubMenuItem11"
                        },

                        new MenuItem
                        {
                            ItemText = "AdminSubMenuItem12"
                        }
                    }
                },

                new MenuItem
                {
                    ItemText = "AdminMenuItem2",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            ItemText = "AdminSubMenuItem21"
                        },

                        new MenuItem
                        {
                            ItemText = "AdminSubMenuItem22"
                        }
                    }
                }
            };
        }
    }
}
