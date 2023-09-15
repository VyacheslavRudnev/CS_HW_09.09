using System.Text;

namespace ConsoleApp090923
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Old { get; set; }
        public string University { get; set; }

        public Student(string name, string surname, int old, string university)
        {
            Name = name;
            Surname = surname;
            Old = old;
            University = university;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3:
//Реалізуйте тип користувача «Студент» з інформацією про ім'я, прізвище, вік, назву навчального закладу.
//Для масиву «Студент» реалізуйте наступні запити:
// Отримати весь масив студентів.
// Отримати список студентів з ім'ям Boris.
// Отримати список студентів з прізвищем, яке починається з Bro.
// Отримати список студентів, старших 19 років.
// Отримати список студентів, старших 20 років і молодших 23 років.
// Отримати список студентів, які навчаються в MIT.
// Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років.Результат відсортуйте за віком, за спаданням.
            Console.WriteLine("HW/Mod13/Pract/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var student = new List<Student>
            {
                new Student("Boris", "Bro", 19, "MIT"),
                new Student("Boris", "Brovko", 20, "Oxford"),
                new Student("Sam", "Woo", 21, "MIT"),
                new Student("Viktor", "Brozovich", 22, "Oxford"),
                new Student("James", "Last", 23, "MIT"),
                new Student("Fedir", "Freemen", 24, "Oxford"),
                new Student("Jon", "Brothers", 25, "MIT"),
                new Student("Juli", "Bond", 26, "Oxford"),
                new Student("Tobby", "Alderweireld", 27, "MIT"),
                new Student("Leo", "Messy", 28, "Oxford"),
                new Student("Kristiano", "Ronaldo", 29, "MIT"),
            };
            Console.WriteLine("Цей додаток працює з запитами, що задовільняють наступним умовам: " +
                "\n1 - Показує весь масив студенті" +
                "\n2 - Показує список студентів з ім'ям Boris" +
                "\n3 - Показує список студентів з прізвищем, яке починається з Bro." +
                "\n4 - Показує список студентів, старших 19 років." +
                "\n5 - Показує список студентів, старших 20 років і молодших 23 років." +
                "\n6 - Показує список студентів, які навчаються в MIT." +
                "\n7 - Показує список студентів, які навчаються в Oxford, і вік яких старше 18 років." +
                "\nРезультат відсортуйте за віком, за спаданням." +
                "\n0 - Завершує роботу");
            do
            {
                Console.Write("Введіть номер запиту: ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1. Повний список студентів.");
                        Console.WriteLine("Варіант 1");
                        var AllStudents = student.Select(x => x);
                        foreach (var item in AllStudents)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var AllStudents2 = from x in student
                                           select x;
                        foreach (var item in AllStudents2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("2. Cписок студентів з ім'ям Boris.");
                        Console.WriteLine("Варіант 1");
                        var BorisStudents = student.Where(x => x.Name == "Boris");
                        foreach (var item in BorisStudents)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var BorisStudents2 = from x in student
                                             where x.Name == "Boris"
                                             select x;
                        foreach (var item in BorisStudents2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("3. Cписок студентів з прізвищем, яке починається з Bro.");
                        Console.WriteLine("Варіант 1");
                        var BroStudents = student.Where(x => x.Surname.StartsWith("Bro"));
                        foreach (var item in BroStudents)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var BroStudents2 = from x in student
                                           where x.Surname.StartsWith("Bro")
                                           select x;
                        foreach (var item in BroStudents2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("4. Cписок студентів, старших 19 років.");
                        Console.WriteLine("Варіант 1");
                        var OldStudents = student.Where(x => x.Old > 19);
                        foreach (var item in OldStudents)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var OldStudents2 = from x in student
                                           where x.Old > 19
                                           select x;
                        foreach (var item in OldStudents2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("5. Cписок студентів, старших 20 років і молодших 23 років.");
                        Console.WriteLine("Варіант 1");
                        var OldStudents2_1 = student.Where(x => x.Old >= 20 && x.Old < 23);
                        foreach (var item in OldStudents2_1)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var OldStudents2_2 = from x in student
                                             where x.Old >= 20 && x.Old < 23
                                             select x;
                        foreach (var item in OldStudents2_2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("6. Cписок студентів, які навчаються в MIT.");
                        Console.WriteLine("Варіант 1");
                        var MITStudents = student.Where(x => x.University == "MIT");
                        foreach (var item in MITStudents)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var MITStudents2 = from x in student
                                            where x.University == "MIT"
                                            select x;
                        foreach (var item in MITStudents2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("7. Cписок студентів, які навчаються в Oxford, і вік яких старше 18 років.Результат відсортуйте за віком, за спаданням.");
                        Console.WriteLine("Варіант 1");
                        var OxfordStudents = student.Where(x => x.University == "Oxford" && x.Old >= 18).OrderByDescending(x => x.Old);
                        foreach (var item in OxfordStudents)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        Console.WriteLine("\nВаріант 2");
                        var OxfordStudents2 = from x in student
                                               where x.University == "Oxford" && x.Old >= 18
                                               orderby x.Old descending
                                               select x;
                        foreach (var item in OxfordStudents2)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Old} {item.University}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Вихід");
                        return;
                    default:
                        Console.WriteLine("Ви зробили невірний вибір");
                        break;
                }
            }while (true);
        }
    }
}