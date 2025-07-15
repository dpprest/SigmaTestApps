using SigmaTestApp1;
using System;
using System.Collections;

    public class Program
    {
        public static void Main()
        {
           var list = new MyArrayList<int>();
           list.Add(1);
           list.Add(2);
           list.Add(3);
           list.Insert(1, 4);
           list[2] = 25;
           Console.WriteLine($"Count: {list.Count}");
           for (int i = 0; i < list.Count; i++)
           {
            Console.WriteLine($"list[{i}] = {list[i]}");
           }
           Console.WriteLine($"Contains 25: {list.Contains(25)}");
           Console.WriteLine($"Index of 25: {list.IndexOf(25)}");
    }

    }
