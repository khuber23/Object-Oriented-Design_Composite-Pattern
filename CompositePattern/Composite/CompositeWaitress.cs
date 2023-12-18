using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Composite
{
	public class CompositeWaitress
	{
		private MenuComponent allMenus;

		public CompositeWaitress(MenuComponent allMenus)
		{
			this.allMenus = allMenus;
		}

		public void PrintMenu()
		{
			allMenus.Print();
		}
	}
}
