using CompositePattern.Composite;
using System;
using System.Security.Cryptography;

namespace CompositePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
			MenuComponent breakfastMenu = new Menu("BREAKFAST MENU", "Breakfast");
			MenuComponent lunchMenu = new Menu("LUNCH MENU", "Lunch");
			MenuComponent dinnerMenu = new Menu("DINNER MENU", "Dinner");
			MenuComponent desertMenu = new Menu("DESERT MENU", "Desert");
			MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(breakfastMenu);
            allMenus.Add(lunchMenu); 
            allMenus.Add(dinnerMenu);

			breakfastMenu.Add(new MenuItem ("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99m));
			breakfastMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99m));
			breakfastMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49m));
			breakfastMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries.", true, 3.59m));

			lunchMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce, tomato on whole wheat.", true, 2.99m));
			lunchMenu.Add(new MenuItem("BLT", "Bacon with lettuce, tomato on whole wheat.", false, 2.99m));
			lunchMenu.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad.", false, 3.29m));
			lunchMenu.Add(new MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05m));

			dinnerMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries.", true, 3.99m));
			dinnerMenu.Add(new MenuItem("Soup of the Day", "A cup of the soup of the day, with a side salad.", false, 3.69m));
			dinnerMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole.", true, 4.29m));

			desertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flaky crust, topped with vanilla icecream", true, 1.59m));
			desertMenu.Add(new MenuItem("Cheesecake", "Creamy New York cheesecake, with a chocolate graham crust", true, 1.99m));
			desertMenu.Add(new MenuItem("Sorbet", "A scoop of raspberry and a scoop of lime", true, 1.89m));

			dinnerMenu.Add(desertMenu);

			CompositeWaitress compositeWaitress = new CompositeWaitress(allMenus);
			compositeWaitress.PrintMenu();
			Console.Read();
		}
    }
}