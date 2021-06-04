using System;

namespace lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student1 = new StudentOfPrograming();
            var student2 = new Student();
            student2.Name = "Alex";
            student2.Lastname = "German";
            student2.Group = 503505;
            student2.PrintInfo();
            student2.Work();
            for (int i = 0; i < 7; i++)
            {
              student2.Sleep(10);  
              student2.GoToUniversity();
            }
            student2.Ability();
            student1.Name = "Vlad";
            student1.Lastname = "Jameson";
            student1.Group = 503505;
            student1.PrintInfo();
            student1.Sleep(10);
            student1.Work();
            student1.Work();
            student1.PrintInfo();
            student1.Ability();
            Student student = new StudentOfPrograming();
            for (int i = 0; i < 10; i++)
            {
                student.Sleep(10);
            }
            student.Ability();
            var students = new Students();
            students[0] = student1;
            students[0].Sleep();
            students[0].Work();
            students[0].PrintInfo();
            students[1] = new StudentOfPrograming();
            students[1].Name = "Vadim";
            students[1].Lastname = "Kopchik";
            students[1].Group = 666999;
            students[1].PrintInfo();
            students[2] = new StudentOfPrograming();
            students[2].Name = "Lesha";
            students[2].Lastname = "Mogilniy";
            students[2].Group = 666999;
            students[2].Work();
            students[2].Work();
            students[2].Work();
            students[2].PrintInfo();
            var studentsOfPrograming = new StudentOfPrograming[]
                {students[0], students[1], students[2]};
            Array.Sort(studentsOfPrograming);
            Console.WriteLine("Who has the least money:  ");
            foreach (var s in studentsOfPrograming)
            {
                Console.WriteLine($"{s.Name} {s.Lastname} - {s.Money}");
            }
            
        }
    }
}