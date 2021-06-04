using System;

namespace lab_3
{
    public class Student : Human, IWorkable
    {
        public Student()
        {
            Intelligence = 90;
            Money = 500;
            SleptWell = false;
        }
        protected static Guid Id = Guid.NewGuid();
        public int Group { get; set; }

        public void Work()
        {
            Console.WriteLine("You working at McDonalds....");
            if (SleptWell)
            {
                Console.WriteLine("You worked well today and get 300 shekelei");
                Money += 300;
                SleptWell = false;
            }
            else
            {
                Console.WriteLine("Today you was so tired and sleep at work.");
                SleptWell = true;
                Console.WriteLine($"For this you get a fine of 100 shekelei :( ");
                Money -= 100;
            }
            Intelligence--;
        }

        public void GoToUniversity()
        {
            Console.WriteLine("Student going to the University...");
            if (SleptWell)
            {
                Intelligence += 3;
                SleptWell = false;
            }
            else
            {
                Console.WriteLine("You so tired and sleep during class!!!");
            }
        }

        public override void Ability()
        {
            if (Intelligence >= 110)
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine("You took the documents from the university");
                Console.WriteLine("*********************************\n");
            }
            else
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine("You don't have enough intelligence");
                Console.WriteLine("*********************************\n");
            }
        }
        
        public override void PrintInfo()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine($"Student : {Name} {Lastname}");
            Console.WriteLine("Specialty : Programing");
            Console.WriteLine($"Group : {Group}");
            Console.WriteLine($"Money : {Money}");
            Console.WriteLine($"Slept well : {SleptWell}");
            Console.WriteLine($"The unique id : {Id}");
            Console.WriteLine($"Intelligence : {Intelligence}");
            Console.WriteLine("*********************************"); 
        }
    }
}