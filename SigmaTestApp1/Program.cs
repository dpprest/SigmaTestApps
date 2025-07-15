using SigmaTestApp1;
using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        var myList = new MyArrayList<string>();
        Console.WriteLine("\n1. Добавляем элементы c помощью Add:");
        myList.Add("Яблоко");
        myList.Add("Банан");
        myList.Add("Апельсин");
        PrintList(myList);

        Console.WriteLine("\n2. Добавляем еще один элемент (емкость должна увеличиться):");
        myList.Add("Груша");
        PrintList(myList);
        Console.WriteLine($"Count: {myList.Count}, Capacity: {myList.Capacity}");

        Console.WriteLine("\n3. Вставляем 'Лимон' на позицию 1 с помощью Insert:");
        myList.Insert(0, "Лимон");
        PrintList(myList);

        Console.WriteLine("\n4. Получаем и изменяем элементы по индексу:");
        Console.WriteLine($"Элемент с индексом 2: {myList[2]}");
        myList[2] = "Манго";
        Console.WriteLine($"После изменения элемента с индексом 2:");
        PrintList(myList);

        Console.WriteLine("\n5. Проверяем наличие элементов:");
        Console.WriteLine($"Содержит 'Банан'? {myList.Contains("Банан")}");
        Console.WriteLine($"Содержит 'Вишня'? {myList.Contains("Вишня")}");

        Console.WriteLine("\n6. Ищем индексы элементов:");
        Console.WriteLine($"Индекс 'Апельсин': {myList.IndexOf("Апельсин")}");
        Console.WriteLine($"Индекс 'Вишня': {myList.IndexOf("Вишня")}");

        Console.WriteLine("\n7. Удаляем элементы:");
        Console.WriteLine("Удаляем 'Банан' (метод Remove):");
        myList.Remove("Банан");
        PrintList(myList);

        Console.WriteLine("\n8. Удаляем элемент с индексом 0 (метод RemoveAt):");
        myList.RemoveAt(0);
        PrintList(myList);

        Console.WriteLine("\n10. Преобразуем список в массив:");
        string[] array = myList.ToArray();
        Console.WriteLine("массив:");
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        Console.WriteLine("\n11. Очищаем список:");
        myList.Clear();
        Console.WriteLine($"После Clear: Count = {myList.Count}, Capacity = {myList.Capacity}");
        PrintList(myList);




        static void PrintList<T>(MyArrayList<T> list)
        {
            Console.WriteLine("Список:");
            if (list.Count == 0)
            {
                Console.WriteLine("[пусто]");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"[{i}] = {list[i]}");
            }
        }

    }
}
