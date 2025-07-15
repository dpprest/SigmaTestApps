using SigmaTestApp1;
using System;
using System.Collections;

    public class Program
    {
        public static void Main()
        {
           var list = new MyArrayList<int>();
           list.Add(10);
           list.Add(20);
           list.Add(30);
           list.Insert(1, 15);
           list[2] = 25;
           list.Remove(30);
           //вывод элементов
           Console.WriteLine($"Count: {list.Count}");
           for (int i = 0; i < list.Count; i++)
           {
            Console.WriteLine($"list[{i}] = {list[i]}");
           }
           //проверка наличия элемент а
           Console.WriteLine($"Contains 25: {list.Contains(25)}");
           Console.WriteLine($"Index of 25: {list.IndexOf(25)}");
    }

    }
