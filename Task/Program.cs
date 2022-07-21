using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Building build_1 = new Building("ул. Ленина, д.1", 12, 6.3, 6);
            MultiBuilding build_2 = new MultiBuilding("проспект Мира", 30, 12, 21, 7);
            MultiBuilding build_3 = new MultiBuilding("ул. Лесная", 5, 5, 3, 1);

            Console.WriteLine(build_1.Print());
            Console.WriteLine(build_2.Print());
            Console.WriteLine(build_3.Print());
            Console.ReadLine();
        }
    }
}
