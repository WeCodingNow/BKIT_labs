using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SimpleStack<T> : SimpleList.SimpleList<T> where T : IComparable
    {


        public void Push(T element)
        {
            Add(element);
        }

        public T Pop()
        {

            SimpleList.SimpleListItem<T> itemPopped = last;
            Count = Count - 1;
            if (Count == 0)
            {
                last = null;
                first = null;
            }
            else
            {
                SimpleList.SimpleListItem<T> newLastItem = this.GetItem(Count - 1);
                newLastItem.next = null;
                last = newLastItem;
            }
            return itemPopped.data;

        }
    }

}
