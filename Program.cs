using System.Text;

namespace ConsoleApp090923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod13/Pract2/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Завдання 1:
            //Для масиву рядків реалізуйте користувальницьке сортування.
            //Сортування має працювати за кількістю символів(за зростанням та спаданням).
            //Наприклад, якщо сортування проводиться за спаданням, потрібно повернути рядки
            //з максимальною довжиною в порядку зменшення довжини.

            string[] str = {"Всім", "Привіт", "Мене", "Звати", "Том", "і", "я", "з", "України" };
            Console.WriteLine("Вихідний масив:");
            foreach (string s in str)
                Console.Write(s + " ");
            Console.WriteLine();
            
            do
            {
                Console.WriteLine("Оберіть спосіб сортування:" +
                "\n 1 - за зростанням" +
                "\n 2 - за спаданням" +
                "\n 3 - вихід");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Сортування за зростанням:");
                        Console.WriteLine("Варіант 1:");
                        var sortUp = from s in str
                                     orderby s.Length
                                     select s;
                        foreach (string s in sortUp)
                            Console.Write(s + " ");
                        Console.WriteLine("\nВаріант 2:");
                        var sortUp2 = str.OrderBy(s => s.Length);
                        foreach (string s in sortUp2)
                            Console.Write(s + " ");
                            Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Сортування за спаданням:");
                        Console.WriteLine("Варіант 1:");
                        var sortDown = from s in str
                                       orderby s.Length descending
                                       select s;
                        foreach (string s in sortDown)
                            Console.Write(s + " ");
                        Console.WriteLine("\nВаріант 2:");
                        var sortDown2 = str.OrderByDescending(s => s.Length);
                        foreach (string s in sortDown2)
                            Console.Write(s + " ");
                            Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Завершення роботи програми");
                        Console.WriteLine();
                        return;
                    default:
                        Console.WriteLine("Невірний вибір опції");
                        Console.WriteLine();
                        break;
                }
            } while (true);

        }
    }
}