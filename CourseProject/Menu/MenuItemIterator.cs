using CourseProject.Menu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Menu
{
    class MenuItemIterator : IMenuItemIterator
    {
        IAggregate aggregate = null;

        public MenuItemIterator(IAggregate agg)
        {
            aggregate = agg;
        }

        public MenuItem FirstItem
        {
            get
            {
                CurrentIndex = 0;
                return aggregate[CurrentIndex];
            }
        }

        public MenuItem NextItem
        {
            get
            {
                CurrentIndex += 1;

                if (IsDone == false)
                {
                    return aggregate[CurrentIndex];
                }
                else
                {
                    return new MenuItem();
                }
            }
        }

        public MenuItem CurrentItem
        {
            get
            {
                return aggregate[CurrentIndex];
            }
        }

        public bool IsDone
        {
            get
            {
                if (CurrentIndex < aggregate.Count)
                {
                    return false;
                }

                return true;
            }
        }

        public int CurrentIndex { get; private set; } = 0;
    }
}
