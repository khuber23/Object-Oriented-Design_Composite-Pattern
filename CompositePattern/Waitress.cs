using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Waitress
    {
        private BreakfastMenu breakfastMenu;

        private DinnerMenu dinnerMenu;

        private LunchMenu lunchMenu;

        public Waitress(BreakfastMenu breakfastMenu, LunchMenu lunchMenu, DinnerMenu dinnerMenu)
        {
            this.breakfastMenu = breakfastMenu;
            this.lunchMenu = lunchMenu;
            this.dinnerMenu = dinnerMenu;
        }

        public void PrintMenu()
        {
            IEnumerator breakfastEnumerator = breakfastMenu.CreateEnumerator();
            IEnumerator lunchEnumerator = lunchMenu.CreateEnumerator();   
            IEnumerator dinnerEnumerator = dinnerMenu.CreateEnumerator();

            Console.WriteLine("MENU\n-----\nBREAKFAST");
            PrintMenu(breakfastEnumerator);

            Console.WriteLine("\nMENU\n-----\nLUNCH");
            PrintMenu(lunchEnumerator);

            Console.WriteLine("\nMENU\n-----\nDINNER");
            PrintMenu(dinnerEnumerator);
        }

        public void PrintMenu(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)enumerator.Current;
                Console.WriteLine(menuItem.ToString()); 
            }
        }
    }
}