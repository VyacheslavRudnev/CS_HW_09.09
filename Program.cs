using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp090923
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 1:
//Для масиву цілих реалізуйте наступні запити:
//- Отримати весь масив цілих.
//- Отримати парні цілі.
//- Отримати непарні цілі.
//- Отримати значення більше заданого.
//- Отримати числа в заданому діапазоні.
//- Отримати числа, кратні семи.Результат відсортуйте за зростанням.
//- Отримати числа, кратні восьми.Результат відсортуйте за спаданням.
            Console.WriteLine("HW/Mod13/Pract/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] MyArray = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < MyArray.Length; i++)
                MyArray[i] = rnd.Next(1, 100);
            // варіант 1
            var AllRes = MyArray.Select(x => x);
            var EvenRes = MyArray.Where(x => x % 2 == 0);
            var OddRes = MyArray.Where(x => x % 2 != 0);
            var MoreRes = MyArray.Where(x => x > 33);
            var RangeRes = MyArray.Where(x => x >= 10 && x <= 45);
            var SevenRes = MyArray.Where(x => x % 7 == 0).OrderBy(x => x);
            var EightRes = MyArray.Where(x => x % 8 == 0).OrderByDescending(x => x);

            // варіант 2
            var AllArrey = from x in MyArray 
                           select x;
            var EvenArrey = from x in MyArray 
                            where x % 2 == 0 
                            select x;
            var OddArrey = from x in MyArray 
                           where x % 2 != 0 
                           select x;
            var MoreArrey = from x in MyArray 
                            where x > 33 
                            select x;
            var RangeArrey = from x in MyArray 
                             where x >= 10 && x <= 45 
                             select x;
            var SevenArrey = from x in MyArray 
                             where x % 7 == 0 
                             orderby x 
                             select x;
            var EightArrey = from x in MyArray 
                             where x % 8 == 0 
                             orderby x 
                             descending select x;
            Console.WriteLine("Рішення виконані двома способами:\n");
            Console.WriteLine("Весь масив цілих:");
            Console.WriteLine("Варіант 1");
            foreach (int i in AllRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in AllArrey)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Парні цілі значення:");
            Console.WriteLine("Варіант 1");
            foreach (int i in EvenRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in EvenArrey)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Непарні цілі значення:");
            Console.WriteLine("Варіант 1");
            foreach (int i in OddRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in OddArrey)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Значення більше 33:");
            Console.WriteLine("Варіант 1");
            foreach (int i in MoreRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in MoreArrey)
            Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Отримуємо числа в діапазоні 10-45:");
            Console.WriteLine("Варіант 1");
            foreach (int i in RangeRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in RangeArrey)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Отримуємо числа, кратні семи.Результат відсортований за зростанням:");
            Console.WriteLine("Варіант 1");
            foreach (int i in SevenRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in SevenArrey)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Отримуємо числа, кратні восьми.Результат відсортований за спаданням:");
            Console.WriteLine("Варіант 1");
            foreach (int i in EightRes)
                Console.Write($"{i} ");
            Console.WriteLine("\nВаріант 2");
            foreach (int i in EightArrey)
                Console.Write($"{i} ");
            Console.WriteLine("\n");

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}