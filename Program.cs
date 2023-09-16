using System.Text;
using System.Linq;

namespace ConsoleApp090923
{
    //Завдання 3:
    //Створіть користувацький тип «Автомобіль», який зберігатиме таку інформацію:
    //- назва;
    //- виробник;
    //- рік випуску.
    //Для двох масивів автомобілів реалізуйте операції:
    //- різниця масивів;
    //- перетин масивів;
    //- об'єднання масивів.
    //Критерій для виконання операцій – виробник.
    public class Car
    {
        public string _Name { get; set; }
        public string _Brand { get; set; }
        public int _Year { get; set; }

        public Car(string name, string brand, int year)
        {
            _Name = name;
            _Brand = brand;
            _Year = year;
        }

        public override string ToString()
        {
            return $"Автомобіль: {_Brand}, {_Name}, {_Year}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod13/Pract/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Car[] cars1 = new Car[4]
            {
                new Car("A4", "Audi", 2010),
                new Car("Polo", "Volkswagen", 2015),
                new Car("333", "Opel", 2018),
                new Car("S5", "Volvo", 2019)
            };
            Car[] cars2 = new Car[5]
            {
                new Car("A4", "Audi", 2010),
                new Car("M5", "BMW", 2013),
                new Car("С", "Mercedes", 2018),
                new Car("Golf", "Volkswagen", 2019),
                new Car("CX-3", "Mazda", 2018)
            };
            Console.WriteLine("Вивід початкового масиву 1:");
            foreach (var item in cars1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВивід початкового масиву 2:");
            foreach (var item in cars2)
            {
                Console.WriteLine(item);
            }
            //знаходимо різницю між двома масивами 
            Console.WriteLine("\nЗнаходимо різницю масивів за назвою виробника (брендом):");
            Console.WriteLine("Варіант 1\nавтомобілі другого масиву без повторень в першому");
            var diff1 = from car1 in cars2
                        where !(from car2 in cars1
                            select car2._Brand)
                                .Contains(car1._Brand)
                        select car1;
            foreach (var item in diff1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 2\nавтомобілі першого масиву без повторень в другому");
            var diff2 = from car2 in cars1
                        where !(from car1 in cars2
                            select car1._Brand)
                                .Contains(car2._Brand)
                        select car2;
            foreach (var item in diff2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 3\nавтомобілі першого масиву без повторень в другому" +
                "\nза назвою бренду");
            var diff3 = cars1.Any(car1 => !cars2.Any(car2 => car2._Brand == car1._Brand)) ?
                cars1.Where(car1 => !cars2.Any(car2 => car2._Brand == car1._Brand)) : null;
            foreach (var item in diff3)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\nВаріант 4\nавтомобілі другого масиву без повторень в першому");
            var diff4 = cars2.Any(car2 => !cars1.Any(car1 => car1._Brand == car2._Brand)) ?
                cars2.Where(car2 => !cars1.Any(car1 => car1._Brand == car2._Brand)) : null;
            foreach (var item in diff4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 5\nавтомобілі першого масиву без повторень в другому");
            var diff5 = cars1.ElementAt(0)._Brand == cars2.ElementAt(0)._Brand ?
                cars1.Where(car1 => !cars2.Any(car2 => car2._Brand == car1._Brand)) : null;
            foreach (var item in diff5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 6\nавтомобілі першого масиву без повторень в другому");
            var diff6 = cars1.ElementAtOrDefault(0)._Brand == cars2.ElementAtOrDefault(0)._Brand ?
                cars1.Where(car1 => !cars2.Any(car2 => car2._Brand == car1._Brand)) : null;
            foreach (var item in diff6)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗнаходимо перетин масивів за назвою виробника (брендом):");
            Console.WriteLine("Варіант 1\nавтомобілі першого масиву, які є в другому");
            var intersect1 = from car1 in cars1
                             where (from car2 in cars2
                             select car2._Brand)
                             .Contains(car1._Brand)
                             select car1;
            foreach (var item in intersect1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 2");
            var intersect2 = cars1.Any(car1 => cars2.Any(car2 => car2._Brand == car1._Brand)) ?
                cars1.Where(car1 => cars2.Any(car2 => car2._Brand == car1._Brand)) : null;
            foreach (var item in intersect2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 3");
            var intersect3 = cars1.ElementAt(0)._Brand == cars2.ElementAt(0)._Brand ?
                cars1.Where(car1 => cars2.Any(car2 => car2._Brand == car1._Brand)) : null;
            foreach (var item in intersect3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nОб'єднуємо два масива:");
            Console.WriteLine("Варіант 1");
            var union1 = cars1.Union(cars2);
            foreach (var item in union1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 2");
            var union2 = cars1.Concat(cars2);
            foreach (var item in union2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 3");
            var union3 = cars1.Concat(cars2).Distinct();
            foreach (var item in union3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 4");
            var union4 = from car1 in cars1
                         select car1;
                foreach (var item in cars2)
                {
                    union4 = union4.Append(item);
                }
            foreach (var item in union4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 4.2 сортуємо за виробником");
            foreach (var item in union4)
            {
                union4 = union4.OrderBy(car => car._Brand); 
            }
            foreach (var item in union4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВаріант 4.5 видаляємо повтори за назвою");
            foreach (var item in union4)
            {
                union4 = union4.DistinctBy(car => car._Name);
            }
            foreach (var item in union4)
            {
                Console.WriteLine(item);
            }
           

        }
    }
}
