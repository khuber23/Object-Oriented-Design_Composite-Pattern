using System.Collections;

namespace CompositePattern
{
    public interface IMenu
    {
        void AddItem(string name, string description, bool isVegetarian, decimal price);

        IEnumerator CreateEnumerator();
    }
}