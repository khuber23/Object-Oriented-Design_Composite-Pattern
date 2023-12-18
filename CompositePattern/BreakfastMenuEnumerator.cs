using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	public class BreakfastMenuEnumerator : IEnumerator
	{
		private ArrayList items;
		private int position;

		public BreakfastMenuEnumerator(ArrayList items)
		{
			this.items = items;
		}

		public bool MoveNext()
		{
			if (position >= items.Capacity || items[position] == null)
			{
				return false;
			}
			return true;
		}

		// Not sure about 
		public object Current
		{
			get
			{
				MenuItem menuItem = (MenuItem)items[position];
				position += 1;
				return menuItem;
			}
		}

		public void Reset()
		{
			position = 0;
		}
	}
}
