using System.ComponentModel;
using System.Text;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.CodeAnalysis;

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
    internal class JournalComparer : IEqualityComparer<Journal>
    {
        public bool Equals(Journal? x, Journal? y)
        {
            if (x == null || y == null)
            {
                return false;
            }
            return x.Name == y.Name && x.Genre.ToLower() == y.Genre.ToLower() && x.NumPages == y.NumPages && x.Date == y.Date;
        }
        int IEqualityComparer<Journal>.GetHashCode(Journal obj)
        {
            throw new NotImplementedException();
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
                new Journal("Журнал 6", "Розваги", 28, "2022"),
                new Journal("Журнал 7", "Футбол", 35, "2021"),
                new Journal("Журнал 8", "Будівництво", 40, "2021"),
                new Journal("Журнал 9", "Шахи", 32, "2021"),
                new Journal("Авто Журнал 10", "каталог", 28, "2021"),
                new Journal("Журнал 11", "Рибалка", 35, "2022"),
                new Journal("Журнал 12", "Дача", 40, "2021"),
                new Journal("Журнал 13", "полювання", 32, "2021"),
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
            Console.WriteLine("Перевірка, чи є хоча б один журнал у жанрі «Сад та город»");
            var anyGenre = journals.Any(journals => journals.Genre == "Сад та город");
            if (anyGenre)
            {
                Console.WriteLine("Результат перевірки - є хоча б один журнал у жанрі «Сад та город»");
            }
            else
            {
                Console.WriteLine("Результат перевірки - немає журналів у жанрі «Сад та город»");
            }
            Console.WriteLine();
            Console.WriteLine("Перевірка, чи є в масиві хоча б один журнал у жанрі «Рибалка»");
            var anyFishing = journals.Any(journals => journals.Genre == "Рибалка");
            if (anyFishing)
            {
                Console.WriteLine("Результат перевірки - є хоча б один журнал у жанрі «Рибалка»");
            }
            else
            {
                Console.WriteLine("Результат перевірки - немає журналів у жанрі «Рибалка»");
            }
            Console.WriteLine();
            Console.WriteLine("Перевірка, чи є в масиві журнали про «Полювання»");
            var containsHunting = journals.Any(journals => journals.Genre.ToLower() == "полювання");
            if (containsHunting)
            {
                Console.WriteLine("Результат перевірки - є журнали про «Полювання»");
            }
            else
            {
                Console.WriteLine("Результат перевірки - немає журналів про «Полювання»");
            }
            Console.WriteLine("\nПеревірка, чи є в масиві журнали про «Полювання» методом Contains");
            var hunting = new Journal("Журнал 13", "Полювання", 32, "2021");
            bool hasHunting = journals.Contains(hunting, new JournalComparer());
            if (hasHunting)
            {
                Console.WriteLine("Результат перевірки - є журнали про «Полювання»");
            }
            else
            {
                Console.WriteLine("Результат перевірки - немає журналів про «Полювання»");
            }
            Console.WriteLine();
            Console.WriteLine("Пошук першого журналу з роком випуску 2022");
            var firstJournal = journals.FirstOrDefault(journals => journals.Date == "2022");
            if (firstJournal != null)
            {
                Console.WriteLine($"Перший журнал з роком випуску 2022 - {firstJournal.Name}");
            }
            else
            {
                Console.WriteLine("Немає журналів з роком випуску 2022");
            }
            Console.WriteLine();
            Console.WriteLine("Пошук останнього журналу, назва якого починається зі слова «Авто»");
            var lastJournal = journals.LastOrDefault(journals => journals.Name.StartsWith("Авто"));
            if (lastJournal != null)
            {
                Console.WriteLine($"Останній журнал, назва якого починається зі слова «Авто» - {lastJournal.Name}");
            }
            else
            {
                Console.WriteLine("Немає журналів, назва яких починається зі слова «Авто»");
            }
        }
    }

    
}