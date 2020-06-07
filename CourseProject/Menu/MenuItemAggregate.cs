using CourseProject.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    public class MenuItemAggregate : IAggregate
    {
        List<MenuItem> menuItems = null;

        public MenuItemAggregate()
        {
            menuItems = new List<MenuItem>();
        }

        public MenuItemAggregate(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public IMenuItemIterator GetIterator()
        {
            return new MenuItemIterator(this);
        }

        public MenuItem this[int itemIndex]
        {
            get
            {
                if (itemIndex < menuItems.Count)
                {
                    return menuItems[itemIndex];
                }

                return new MenuItem();
            }
            set
            {
                menuItems.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return menuItems.Count;
            }
        }
    }
}
