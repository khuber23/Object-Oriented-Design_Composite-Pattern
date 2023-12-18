using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	public class Menu : MenuComponent
	{
		private ArrayList menuComponents = new ArrayList();

		public Menu(string description, string name)
		{
			this.description = description;
			this.name = name;
		}

		public override void Add(MenuComponent menuComponent)
		{
			menuComponents.Add(menuComponent);
		}

		public override void Remove(MenuComponent menuComponent)
		{
			menuComponents.Remove(menuComponent);
		}

		public override MenuComponent GetChild(int i)
		{
			return (MenuComponent)menuComponents[i];
		}

		public override void Print()
		{
			Console.WriteLine($"\n{this.Name}, {this.Description}\n-------------------------");
			IEnumerator enumerator = menuComponents.GetEnumerator();
			while( enumerator.MoveNext() )
			{
				MenuComponent menuComponent = (MenuComponent)enumerator.Current;
				menuComponent.Print();
			}
		}
	}
}
