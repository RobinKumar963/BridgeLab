using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DataStructure
{
    class MyutilityTest 
    {
        public static void Main(String[] args)
        {
            MyUtility.UnOrderedList<int> list = new MyUtility.UnOrderedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Pop());
            Console.WriteLine(list.Pop());
            

        }

        
    }
}
