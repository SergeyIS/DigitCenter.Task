using System;
using System.Collections.Generic;

namespace DigitCenter.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EntryObject> entryObjects = new List<EntryObject>();//Коллекция для хранения объектов

            PrintStartMenu();
            Console.Write("> ");
            String input = Console.ReadLine();
            while (!input.Equals("Q", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    switch (input)
                    {
                        case "1":
                            PrintData(entryObjects);
                            break;
                        case "2":
                            AddItem(entryObjects);
                            break;
                        case "3":
                            RemoveItem(entryObjects);
                            break;
                        default:
                            Console.WriteLine("Неизвестная команда\n");
                            break;
                    }

                    PrintStartMenu();
                    Console.Write("> ");
                    input = Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.Message}\n");
                }
            }
        }
        /// <summary>
        /// Выводит список объектов в коллекции list
        /// </summary>
        /// <param name="list"></param>
        static void PrintData(List<EntryObject> list)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Коллекция пуста\n");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}. {list[i]}");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Добавляет новый объект в коллекцию list
        /// </summary>
        /// <param name="list"></param>
        static void AddItem(List<EntryObject> list)
        {
            Console.WriteLine("Выберете тип объекта для добавления: ");
            Console.WriteLine("1.Message\n2.Person\n3.Car\nQ.Exit\n");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Message: ");
                    var m = Console.ReadLine();
                    list.Add(new Message(m));
                    break;
                case "2":
                    String fname, lname, age;
                    Console.Write("First name: ");
                    fname = Console.ReadLine();
                    Console.Write("Last name: ");
                    lname = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Console.ReadLine();
                    list.Add(new Person(fname, lname, Int32.Parse(age)));
                    break;
                case "3":
                    String title, year;
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    Console.Write("Year: ");
                    year = Console.ReadLine();
                    list.Add(new Car(title, Int32.Parse(year)));
                    break;
                default:
                    return;
            }

            Console.WriteLine("Объект добавлен\n");
        }

        /// <summary>
        /// Удаляет объект, выбранный пользователем, из коллекции
        /// </summary>
        /// <param name="list"></param>
        static void RemoveItem(List<EntryObject> list)
        {
            Console.Write("Введите номер объекта для удаления: ");
            list.RemoveAt(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Объект удален");
        }

        /// <summary>
        /// Выводит стартовое меню
        /// </summary>
        static void PrintStartMenu()
        {
            Console.WriteLine("1. Print data");
            Console.WriteLine("2. Add item");
            Console.WriteLine("3. Remove item");
            Console.WriteLine("Q. Exit");
            Console.WriteLine();
        }
    }
}
