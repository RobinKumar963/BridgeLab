using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Bridgelabz.ObjectOriented
{
    public class LinkListItem : IComparable
    {
        public int valueA;
        public int valueB;

        public LinkListItem(int valueA, int valueB)
        {
            this.valueA = valueA;
            this.valueB = valueB;
        }
        public LinkListItem()
        {
            this.valueA = 0;
            this.valueB = 0;
        }
        public void Show()
        {
            Console.WriteLine();
            Console.Write("{0}and{1}", valueA, valueB);
        }
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
