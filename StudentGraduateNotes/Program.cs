using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGraduateNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 4; i++)
            {
                var newStudent = new Student();
                newStudent.getValues(i + 1);
                students.Add(newStudent);
            }

            Console.WriteLine("Min graduate note {0}",students.Select(p=>p.GraduateNote).Min());
            Console.WriteLine("Max graduate note {0}", students.Select(p => p.GraduateNote).Max());
            Console.WriteLine("Avarage graduate note{0}", students.Select(p => p.GraduateNote).Average());
            Console.ReadLine();
        }
    }

    class Student
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Number { get; set; }
        public double MidTermExam { get; set; }
        public double FinalExam { get; set; }
        public double GraduateNote { 
            get {
                return MidTermExam*0.3 + FinalExam*0.7;
            } 
        }

        public void getValues(int orderNo)
        {
            Console.WriteLine("Please enter number for {0}.student", orderNo);
            Number = Console.ReadLine();
            Console.WriteLine("Please enter name for {0}.student", orderNo);
            Name = Console.ReadLine();
            Console.WriteLine("Please enter surname for {0}.student", orderNo);
            Surname = Console.ReadLine();
            Console.WriteLine("Please enter midterm exam note for  {0}.student", orderNo);
            MidTermExam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter final exam note for  {0}.student", orderNo);
            FinalExam = Convert.ToDouble(Console.ReadLine());

        }

    }
}
