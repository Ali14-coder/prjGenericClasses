using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGenericClasses
{
    internal class Stack_Item<T> //this makes a generic array from scratch
    {
        private static object[] item;
        private static int stackPointer = 0;
        private string strDisplay;

        public Stack_Item(int size)
        {
            item = new object[size];
        }

        public string Display()
        {
            for (int x =0; x< stackPointer; x++)
            {
                strDisplay += item[x] + "\n";
            }
            return strDisplay;
        }

        public void Push(object anItem)
        {
            item[stackPointer] = anItem;
            stackPointer++;
        }

    }
}
