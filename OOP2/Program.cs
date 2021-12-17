using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultate UEO = new Facultate("UEO");
            UEO.Students = new Student[] {new Student("Gurau", "Amalia", new DateTime(2002, 01, 01), "12345678"),
                              new Student("Turcu", "Iosif", new DateTime(2002, 01, 02), "87654321"),
                              new Student("Daniel", "Andrei", new DateTime(2002, 01, 03), "00000000"),
                              new Student("Petrila", "Damaris", new DateTime(2002, 01, 03), "76543210"),
                              new Student("Afloarei", "David", new DateTime(2002, 01, 04), "01234567")};

            Console.Write("Introduceti Numarul de matricol:  ");
            Console.WriteLine(UEO.Index(Console.ReadLine()));

        }
    }
}