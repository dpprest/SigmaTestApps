using SigmaTestApp1;
using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        var myList = new MyArrayList<string>();
        Console.WriteLine("\n Добавляем элементы c помощью Add:");
        myList.Add("Яблоко");
        myList.Add("Банан");
        myList.Add("Апельсин");
        PrintList(myList);

        Console.WriteLine("\n2. Добавляем еще один элемент (емкость должна увеличиться):");
        myList.Add("Груша");
        PrintList(myList);
        Console.WriteLine($"Count: {myList.Count}, Capacity: {myList.Capacity}");

        // 3. Вставка элемента (Insert)
        Console.WriteLine("\n3. Вставляем 'Лимон' на позицию 1 с помощью Insert:");
        myList.Insert(0, "Лимон");
        PrintList(myList);

        // 4. Доступ по индексу
        Console.WriteLine("\n4. Получаем и изменяем элементы по индексу:");
        Console.WriteLine($"Элемент с индексом 2: {myList[2]}");
        myList[2] = "Манго";
        Console.WriteLine($"После изменения элемента с индексом 2:");
        PrintList(myList);

        // 5. Проверка наличия элемента
        Console.WriteLine("\n5. Проверяем наличие элементов:");
        Console.WriteLine($"Содержит 'Банан'? {myList.Contains("Банан")}");
        Console.WriteLine($"Содержит 'Вишня'? {myList.Contains("Вишня")}");

        // 6. Поиск индекса элемента (IndexOf)
        Console.WriteLine("\n6. Ищем индексы элементов:");
        Console.WriteLine($"Индекс 'Апельсин': {myList.IndexOf("Апельсин")}");
        Console.WriteLine($"Индекс 'Вишня': {myList.IndexOf("Вишня")}");

        // 7. Удаление элементов (Remove и RemoveAt)
        Console.WriteLine("\n7. Удаляем элементы:");
        Console.WriteLine("Удаляем 'Банан' (метод Remove):");
        myList.Remove("Банан");
        PrintList(myList);

        Console.WriteLine("Удаляем элемент с индексом 0 (метод RemoveAt):");
        myList.RemoveAt(0);
        PrintList(myList);

        //Изменение емкости (Capacity)
        Console.WriteLine("\n Изменяем емкость списка:");
        Console.WriteLine($"Текущая емкость: {myList.Capacity}");
        myList.Capacity = 10;
        Console.WriteLine($"После увеличения емкости до 10: {myList.Capacity}");
        myList.Capacity = 2;
        Console.WriteLine($"После уменьшения емкости до 2 (но Count = {myList.Count}): {myList.Capacity}");

        //Преобразование в массив
        Console.WriteLine("\n Преобразуем список в массив:");
        string[] array = myList.ToArray();
        Console.WriteLine("массив:");
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        //Очистка списка
        Console.WriteLine("\n10. Очищаем список:");
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
