using System;

namespace CompositePattern
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            this.name = name;
            this.description = description;
            this.isVegetarian = isVegetarian;
            this.price = price;
        }

        public override void Print()
        {
			string veg = this.IsVegetarian ? "(v)" : string.Empty;

			Console.WriteLine($"\t{this.Name}{veg}, {this.Price}\n\t\t-- {this.Description}");
		}
    }
}