using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_LR1.Program;

namespace OOP_LR1
{
    internal class Program
    {
        public class Item
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Price { get; set; }

            public Item(string name, int age, decimal price)
            {
                Name = name;
                Age = age;
                Price = price;
            }
        }

        static void WriteToFile(List<Item> items, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                Console.WriteLine($"Запись в файл: {fileName}");
                foreach (var item in items)
                {
                    
                    writer.WriteLine($"Name: {item.Name}, Age: {item.Age}, Price: {item.Price}");
                    

                }
                Console.WriteLine($"Запись в файл {fileName} завершена");
                
            }
            
        }

        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
        {
            new Item("Item1", 10, 9.99m),
            new Item("Item2", 20, 19.99m),
            new Item("Item3", 11, 29.99m),
            new Item("Item4", 19, 14.99m),
            new Item("Item5", 35, 74.99m),
            new Item("Item6", 44, 43.99m),
            new Item("Item7", 98, 44.99m),
            new Item("Item8", 47, 12.99m),
            new Item("Item9", 88, 27.99m),
            new Item("Item10", 15, 79.99m)

        };

            // Сортировка массива по полям
            List<Item> sortedByName = items.OrderBy(item => item.Name).ToList();
            List<Item> sortedByAge = items.OrderBy(item => item.Age).ToList();
            List<Item> sortedByPrice = items.OrderBy(item => item.Price).ToList();

            // Запись в файл
            WriteToFile(sortedByName, "sortedByName.txt");
            WriteToFile(sortedByAge, "sortedByAge.txt");
            WriteToFile(sortedByPrice, "sortedByPrice.txt");
            Console.Read();
        }
    }



}
