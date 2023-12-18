using System;
using System.Collections;

namespace CompositePattern
{
    public class LunchMenu : IMenu
    {
        private readonly int maxItems = 4;

        private MenuItem[] menuItems;

        private int numberOfItems = 0;

        public LunchMenu()
        {
            this.menuItems = new MenuItem[maxItems];
        }

        public MenuItem[] MenuItems => this.menuItems;

        public void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);

            if (this.numberOfItems >= this.maxItems)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to the menu");
            }
            else
            {
                this.menuItems[this.numberOfItems] = menuItem;
                this.numberOfItems++;
            }
        }

		public IEnumerator CreateEnumerator()
		{
			return this.menuItems.GetEnumerator();
		}
	}
}