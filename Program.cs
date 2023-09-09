using System.Text;

namespace ConsoleApp090923
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 2:
//Для двох масивів цілих реалізуйте такі запити:
// Отримати різницю двох масивів(елементи першого масиву, яких немає у другому).
// Отримати перетин масивів(спільні елементи для обох масивів).
// Отримати об'єднання масивів (елементи обох масивів без дублікатів).
// Отримати вміст першого масиву без повторень.
            Console.WriteLine("HW/Mod13/Pract2/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int[] arr1 = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 1 };
            int[] arr2 = { 2, 4, 6, 8, 10, 12, 14, 16 };

            Console.WriteLine("Перший початковий масив:");
            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nДругий початковий масив:");
            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nРізниця двох масивів (елементи першого масиву, яких немає у другому):");
            Console.Write("Перший спосіб (втрачаються повторювані значення): ");
            var diff = arr1.Except(arr2);
            foreach (int i in diff)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nДругий спосіб: ");
            var diff2 = arr1.Where(x => !arr2.Contains(x));
            foreach (int i in diff2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nПеретин масивів (спільні елементи для обох масивів):");
            Console.Write("Перший спосіб: ");
            var intersect = arr1.Intersect(arr2);
            foreach (int i in intersect)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nДругий спосіб: ");
            var intersect2 = arr1.Where(x => arr2.Contains(x));
            foreach (int i in intersect2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nОб'єднання масивів (елементи обох масивів без дублікатів):");
            Console.Write("Перший спосіб: ");
            var union = arr1.Union(arr2);
            foreach (int i in union)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nДругий спосіб: ");
            var union2 = arr1.Concat(arr2).Distinct();
            foreach (int i in union2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nВміст першого масиву без повторень:");
            Console.Write("Перший спосіб: ");
            var distinct = arr1.Distinct();
            foreach (int i in distinct)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nДругий спосіб: ");
            var distinct2 = arr1.GroupBy(x => x).Select(x => x.First());
            foreach (int i in distinct2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}