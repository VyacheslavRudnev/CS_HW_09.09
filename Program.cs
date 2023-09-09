using System;
using System.Text;

namespace ConsoleApp090923
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 2:
//Для масиву рядків з назвою міст, реалізуйте наступні запити:
//Отримати весь масив міст.
//Отримати міста з довжиною назви, що дорівнює заданому.
//Отримати міста, назви яких починаються з літери A.
//Отримати міста, назви яких закінчуються літерою M.
//Отримати міста, назви яких починаються з літери N і закінчуються літерою K.
//Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням.
            Console.WriteLine("HW/Mod13/Pract/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string[] cities = { "Alabama", "New-York", "Washington", "Nemiroff", "Kyiv", 
                "Mykolaiv", "London", "Paris", "Nevidome Misto", "Antverpen", 
                "Amsterdam", "Birmingem", "Horodok" };

            Console.WriteLine("Цей додаток працює з запитами, що задовільняють наступним умовам: " +
                "\n1 - Показує весь масив міст" +
                "\n2 - Показує міста, назви яких починаються з літери A" +
                "\n3 - Показує міста, назви яких закінчуються літерою M." +
                "\n4 - Показує міста, назви яких починаються з літери N і закінчуються літерою K." +
                "\n5 - Показує міста, назви яких починаються з Ne. Результат відсортувати за спаданням." +
                "\n6 - Завершує роботу");

            do
            {
                Console.WriteLine("\nВведіть номер запиту: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Весь масив міст: ");
                        Console.WriteLine("Варіант 1: ");
                        var AllCities = from city in cities
                                        select city;
                        foreach (string city in AllCities)
                        {
                            Console.Write($"{city} ");
                        }
                        Console.WriteLine("\nВаріант 2: ");
                        var AllCities2 = cities.Select(city => city);
                        foreach (string city in AllCities2)
                        {
                            Console.Write($"{city} ");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Міста, назви яких починаються з літери A: ");
                        Console.WriteLine("Варіант 1: ");
                        var CitiesA = from city in cities
                                      where city.StartsWith("A")
                                      select city;
                        foreach (string city in CitiesA)
                        {
                            Console.WriteLine(city);
                        }
                        Console.WriteLine("\nВаріант 2: ");
                        var CitiesA2 = cities.Where(city => city.StartsWith("A"));
                        foreach (string city in CitiesA2)
                        {
                            Console.WriteLine(city);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Міста, назви яких закінчуються літерою M: ");
                        Console.WriteLine("Варіант 1: ");
                        var CitiesM = from city in cities
                                      where city.EndsWith("m")
                                      select city;
                        foreach (string city in CitiesM)
                        {
                            Console.WriteLine(city);
                        }
                        Console.WriteLine("\nВаріант 2: ");
                        var CitiesM2 = cities.Where(city => city.EndsWith("m"));
                        foreach (string city in CitiesM2)
                        {
                            Console.WriteLine(city);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Міста, назви яких починаються з літери N і закінчуються літерою K:");
                        Console.WriteLine("Варіант 1: ");
                        var CitiesNK = from city in cities
                                       where city.StartsWith("N") && city.EndsWith("k")
                                       select city;
                        foreach (string city in CitiesNK)
                        {
                            Console.WriteLine(city);
                        }
                        Console.WriteLine("\nВаріант 2: ");
                        var CitiesNK2 = cities.Where(city => city.StartsWith("N") && city.EndsWith("k"));
                        foreach (string city in CitiesNK2)
                        {
                            Console.WriteLine(city);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Міста, назви яких починаються з Ne. Результат відсортувано за спаданням:");
                        Console.WriteLine("Варіант 1: ");
                        var CitiesNe = from city in cities
                                       where city.StartsWith("Ne")
                                       orderby city descending
                                       select city;
                        foreach (string city in CitiesNe)
                        {
                            Console.WriteLine(city);
                        }
                        Console.WriteLine("\nВаріант 2: ");
                        var CitiesNe2 = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city);
                        foreach (string city in CitiesNe2)
                        {
                            Console.WriteLine(city);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Завершення роботи");
                        return;
                    default:
                        Console.WriteLine("Невірний номер запиту");
                        break;
                }
            } while (true);
        }
    }
}