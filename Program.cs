using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp090923
{
    internal class Program
    {
//Завдання 1:
//Для масиву прізвищ виконайте наступні завдання:
//- Перевірте, чи всі прізвища мають довжину більше трьох символів.Використовуйте метод All.
//- Перевірте, чи всі прізвища мають довжину більше трьох і менше десяти символів.Використовуйте метод All.
//- Перевірте, чи є в масиві хоча б одне прізвище, яке починається з літери «W». Використовуйте метод Any.
//- Перевірте, чи є в масиві хоча б одне прізвище, яке закінчується на літеру «Y». Використовуйте метод Any.
//- Перевірте, чи є у масиві прізвище Orange. Використовуйте метод Contains.
//- Відобразіть перше прізвище з довжиною 6. Використовуйте метод FirstOrDefault.
//- Відобразіть останнє прізвище з довжиною менше 15. Використовуйте метод LastOrDefault.
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod13/HW/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Цей додаток дозволяє працювати з масивом призвищ за наступними параметрами:" +
                "\n 1 - Перевірка, чи всі прізвища мають довжину більше трьох символів" +
                "\n 2 - Перевірка, чи всі прізвища мають довжину більше трьох і менше десяти символів" +
                "\n 3 - Перевірка, чи є в масиві хоча б одне прізвище, яке починається з літери «W»" +
                "\n 4 - Перевірка, чи є в масиві хоча б одне прізвище, яке закінчується на літеру «Y»" +
                "\n 5 - Перевірка, чи є у масиві прізвище Orange" +
                "\n 6 - Відображення першого прізвища з довжиною 6" +
                "\n 7 - Відображення останнього прізвища з довжиною менше 15" +
                "\n 0 - Завершення роботи програми");
           

            string[] surnames = { "Smith", "Brown", "White", "Black", "Green", "Orange", "Red", "Grey", "Pink", "Yellow", "Alreadyfifteenyearsold" };
            do
            {
                Console.WriteLine("\nОберіть неодхідну опцію?");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Перевірка, чи всі прізвища мають довжину більше трьох символів");
                        Console.WriteLine(surnames.All(s => s.Length >= 3));
                        break;
                    case 2:
                        Console.WriteLine("Перевірка, чи всі прізвища мають довжину більше трьох і менше десяти символів");
                        Console.WriteLine(surnames.All(s => s.Length >= 3 && s.Length <= 10));
                        break;
                    case 3:
                        Console.WriteLine("Перевірка, чи є в масиві хоча б одне прізвище, яке починається з літери «W»");
                        Console.WriteLine(surnames.Any(s => s.StartsWith("W")));
                        break;
                    case 4:
                        Console.WriteLine("Перевірка, чи є в масиві хоча б одне прізвище, яке закінчується на літеру «Y»");
                        Console.WriteLine(surnames.Any(s => s.EndsWith("Y")));
                        break;
                    case 5:
                        Console.WriteLine("Перевірка, чи є у масиві прізвище Orange");
                        Console.WriteLine(surnames.Contains("Orange"));
                        break;
                    case 6:
                        Console.WriteLine("Відображення першого прізвища з довжиною 6");
                        Console.WriteLine(surnames.FirstOrDefault(s => s.Length == 6));
                        break;
                    case 7:
                        Console.WriteLine("Відображення останнього прізвища з довжиною менше 15");
                        Console.WriteLine(surnames.LastOrDefault(s => s.Length < 15));
                        break;
                    case 0:
                        Console.WriteLine("Завершення роботи програми");
                        return;
                    default:
                        Console.WriteLine("Ви ввели невірну опцію");
                        break;
                }
            } while (true);
            
            
           
           


        }
    }
}