using System;
using System.Collections.Generic;

namespace @class
{
    class MainClass
    {
        static void Main()
        {
            Adress add1 = new Adress("Ukraine", "Kherson", "Subboty", 25);

            Student st1 = new Student("Rostislav", "Zasukhin", 18, 1.82, 80, false, Nation.Ukranian, add1, 1, "32-12", "FKNFM");
            Student st2 = new Student("Viktor", "Sergienko", 18, 1.70, 80, false, Nation.Ukranian, add1, 1, "32-12", "FKNFM");
            Student st3 = new Student("Li", "Sin", 20, 1.82, 80, true, Nation.Ukranian, add1, 1, "21-12", "FKNFM");
            Student st4 = new Student("Ksin", "Jao", 25, 1.90, 80, false, Nation.Ukranian, add1, 1, "21-12", "FKNFM");
            Student st5 = new Student("Le", "Blan", 20, 1.60, 80, false, Nation.Ukranian, add1, 1, "33-12", "FKNFM");
            
            st1.printInfo();
            st5.printInfo();
            Console.WriteLine("\n\n\n");

            ListStudent stList1 = new ListStudent();
            stList1.Add(st1);
            stList1.Add(st2);
            stList1.Add(st3);

            ListStudent stList2 = new ListStudent();
            stList2.Add(st1);
            stList2.Add(st4);
            stList2.Add(st5);

            ListStudent stList3 = new ListStudent();
            stList3.Add(st1);
            stList3.Add(st2);
            stList3.Add(st3);
            stList3.Add(st4);
            stList3.Add(st5);

            ListStudent stList4 = new ListStudent();
            stList4.Add(st3);
            stList4.Add(st4);
            stList4.Add(st5);

            Teacher teacher1 = new("Mao", "Kai", 40, 1.72, 80, true, Nation.Ukranian, add1, "KSU", "Docent", "FKNFM");
            Teacher teacher2 = new("Kog", "Mao", 54, 1.82, 80, true, Nation.Ukranian, add1, "KSU", "Rector", "FKNFM");
            Teacher teacher3 = new("Renata", "Glask", 48, 1.82, 80, true, Nation.Ukranian, add1, "KSU", "Pro-Rector", "FKNFM");

            teacher1.printInfo();
            teacher3.printInfo();
            Console.WriteLine("\n\n\n");

            ListTeacher teacherList = new ListTeacher();
            teacherList.Add(teacher1);
            teacherList.Add(teacher2);
            teacherList.Add(teacher3);

            teacherList.Print();
            Console.WriteLine("\n\n\n");
        }
    }
}