using System.Collections;
using System.Collections.Generic;

namespace CompositePattern
{
    public class DinnerMenu : IMenu
    {
        private Dictionary<string, MenuItem> menuItems;

        public DinnerMenu()
        {
            this.menuItems = new Dictionary<string, MenuItem>();
        }

        public Dictionary<string, MenuItem> MenuItems => this.menuItems;

        public void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            this.menuItems.Add(menuItem.Name, menuItem);
        }

		public IEnumerator CreateEnumerator()
		{
			return this.menuItems.Values.GetEnumerator();
		}
	}
}