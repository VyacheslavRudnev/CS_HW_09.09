using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp090923
{
//Завдання 2:
//Створіть користувацький тип «Журнал», який зберігатиме таку інформацію:
//- Назва журналу.
//- Жанр.
//- Кількість сторінок у випуску.
//- Дата видання.
//Для масиву журналів виконайте наступні завдання:
//- Перевірте, чи у всіх журналів кількість сторінок більше 30. Використовуйте метод All.
//- Перевірте, чи всі журнали у жанрі «Політика», «Мода» або «Спорт». Використовуйте метод All.
//- Перевірте, чи є хоча б один журнал у жанрі «Сад та город». Використовуйте метод Any.
//- Перевірте, чи є в масиві хоча б один журнал у жанрі «Рибалка». Використовуйте метод Any.
//- Перевірте, чи є в масиві журнали про «Полювання». Використовуйте метод Contains.
//Зверніть увагу, що «Полювання» може бути написано у будь-якому регістрі. Тож ігноруйте регістр.
//- Відобразіть перший журнал з роком випуску 2022. Використовуйте метод FirstOrDefault.
//- Відобразіть останній журнал, назва якого починається зі слова «Авто». Використовуйте метод LastOrDefault.

    public class Journal
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumPages { get; set; }
        public string Date { get; set; }

        public Journal(string name, string genre, int pages, string date)
        {
            Name = name;
            Genre = genre;
            NumPages = pages;
            Date = date;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod13/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Journal[] journals =
            {
                new Journal("Журнал 1", "Політика", 32, "2021"),
                new Journal("Журнал 2", "Мода", 28, "2021"),
                new Journal("Журнал 3", "Спорт", 35, "2021"),
                new Journal("Журнал 4", "Сад та город", 40, "2021"),
                new Journal("Журнал 5", "Культура", 32, "2021"),
                new Journal("Журнал 6", "Розваги", 28, "2021"),
                new Journal("Журнал 7", "Футбол", 35, "2021"),
                new Journal("Журнал 8", "Будівництво", 40, "2021"),
                new Journal("Журнал 9", "Шахи", 32, "2021"),
                new Journal("Журнал 10", "каталог", 28, "2021"),
                new Journal("Журнал 11", "Рибалка", 35, "2021"),
                new Journal("Журнал 12", "Дача", 40, "2021"),
                new Journal("Журнал 13", "Полювання", 32, "2021"),
                new Journal("Журнал 14", "Зброя", 28, "2021"),
                new Journal("Журнал 15", "Сад та город", 22, "1981")
            };

            Console.WriteLine("Перевірка, чи у всіх журналів кількість сторінок більше 30");
            var allPages = journals.All(journal => journal.NumPages > 30);
            if (allPages)
            {
                Console.WriteLine("Результат перевірки - У всіх журналів кількість сторінок більше 30");
            }
            else
            {
                Console.WriteLine("Результат перевірки - Не у всіх журналів кількість сторінок більше 30");
            }
            Console.WriteLine();
            Console.WriteLine("Перевірка, чи всі журнали у жанрі «Політика», «Мода» або «Спорт»");
            var allGenre = journals.All(journals => journals.Genre == "Політика" || journals.Genre == "Мода" || journals.Genre == "Спорт");
            if (allGenre)
            {
                Console.WriteLine("Результат перевірки - всі журнали в жанрах «Політика», «Мода» або «Спорт»");
            }
            else
            {
                Console.WriteLine("Результат перевірки - не всі журнали в жанрах «Політика», «Мода» або «Спорт»");
            }
            Console.WriteLine();

        }
    }
}