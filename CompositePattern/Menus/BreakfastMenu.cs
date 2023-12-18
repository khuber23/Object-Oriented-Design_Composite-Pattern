using System.Collections;

namespace CompositePattern
{
    public class BreakfastMenu : IMenu
    {
        private ArrayList menuItems;

        public BreakfastMenu()
        {
            this.menuItems = new ArrayList();
        }

        public void AddItem(string name, string description, bool isVegetarian, decimal price)
        {
            this.menuItems.Add(new MenuItem(name, description, isVegetarian, price));
        }

        public IEnumerator CreateEnumerator()
        {
            BreakfastMenuEnumerator breakfastMenuEnumerator = new BreakfastMenuEnumerator(menuItems);
            return breakfastMenuEnumerator;
        }
    }
}