using System;
using System.Collections.Generic;

namespace RegisterLib
{
    public class Register
    {
        private List<double> itemList;
        private double total;

        public Register()
        {
            //itemList = new List<double>();
        }

        public double Total { get => total; }

        public double NItems => itemList.Count;

        public void AddItem(double item)
        {
            if (item < 0)
                throw new ArgumentException("Idiot!");

            itemList.Add(item);
            total += item;
        }
    }
}
