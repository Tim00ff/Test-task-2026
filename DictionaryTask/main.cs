using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> orders = new Dictionary<string, int>();
        string[] clients = {
            "Анна", "Иван", "Мария", "Анна", "Петр",
            "Иван", "Ольга", "Мария", "Сергей", "Анна"
        };
		 
		Console.WriteLine("Массив клиентов:");
        foreach (string name in clients)
        {
			Console.WriteLine(name);
            if (orders.ContainsKey(name))
            {
                // Если клиент уже есть, увеличиваем количество заказов
                orders[name]++;
            }
            else
            {
                // Иначе добавляем нового клиента с одним заказом
                orders[name] = 1;
            }
        }
		Console.WriteLine();

        Console.WriteLine("Список клиентов и количество их заказов:");
        foreach (var pair in orders)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} заказ(ов)");
        }

        string bestClient = "none";
        int maxOrders = -1;

        foreach (var pair in orders)
        {
            if (pair.Value > maxOrders)
            {
                maxOrders = pair.Value;
                bestClient = pair.Key;
            }
        }
        Console.WriteLine($"\nКлиент с наибольшим числом заказов: {bestClient} ({maxOrders} заказ(ов))");
    }
}