using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	public abstract class MenuComponent
	{
		protected string description;
		protected string name;
		protected bool isVegetarian;
		protected decimal price;

		public string Description
		{
			get { return description; }
		}

		public bool IsVegetarian
		{
			get { return isVegetarian;}
		}

		public string Name
		{
			get { return name; }
		}

		public decimal Price
		{
			get { return price; }
		}

		public virtual void Add(MenuComponent menuComponent)
		{
			throw new NotSupportedException();
		}

		public virtual void Remove(MenuComponent menuComponent)
		{
			throw new NotSupportedException();
		}

		public virtual MenuComponent GetChild(int i)
		{
			throw new NotSupportedException();
		}

		public virtual void Print()
		{
			throw new NotSupportedException();
		}
	}
}
