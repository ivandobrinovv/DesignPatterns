using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    class GuestMenu
    {
        internal List<MenuItem> GetGuestMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem
                {
                    ItemText = "GuestMenuItem1",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            ItemText = "GuestSubMenuItem11"
                        },

                        new MenuItem
                        {
                            ItemText = "GuestSubMenuItem12"
                        }
                    }
                },

                new MenuItem
                {
                    ItemText = "GuestMenuItem2",
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            ItemText = "GuestSubMenuItem21"
                        },

                        new MenuItem
                        {
                            ItemText = "GuestSubMenuItem22"
                        }
                    }
                }
            };
        }
    }
}
