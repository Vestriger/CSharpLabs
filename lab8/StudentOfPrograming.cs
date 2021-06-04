using System;
using System.Collections.Generic;

namespace lab_3
{

    public class StudentOfPrograming : Student, IComparable
    {
        public StudentOfPrograming(int intelligence)
        {
            Intelligence = intelligence;
            Money = 1000;
            IntelligenceLevel intelligenceLevelDelegate;

            if (Intelligence < 100)
                intelligenceLevelDelegate = Stupid;

            else if (Intelligence >= 100)
                intelligenceLevelDelegate = Clever;
            else
                throw new Exception("Error");

            intelligenceLevelDelegate();
        }
        public StudentOfPrograming()
        {
            Intelligence = 100;
            Money = 1000;
            
            IntelligenceLevel intelligenceLevelDelegate;

            if (Intelligence <= 100)
                intelligenceLevelDelegate = Stupid;

            else if (Intelligence > 120)
                intelligenceLevelDelegate = Clever;

            else
                throw new Exception("Error");

            intelligenceLevelDelegate();
        }

        private int _numberOfPrograms;
        public int NumberOfLabs;
        
        public delegate void PracticeStateHandler(string message);
        
        public event PracticeStateHandler Added;

        public event PracticeStateHandler Substract;
        
        public void PracticeInProgramming(int _Intelligence)
        {
            Intelligence += _Intelligence;
            if (Added != null)
                Added($"You watch educating videos and earned {_Intelligence} intelligence");
            else
                throw new Exception("Error");
        }

        public void Withdraw(int _Intelligence)
        {
            if (Intelligence >= _Intelligence)
            {
                Intelligence -= _Intelligence;
                if (Substract != null)
                    Substract($"You watch useless videos and lose {_Intelligence} intelligence");
            }
            else if (Intelligence < _Intelligence)
            {
                if (Substract != null)
                    Substract("You don't have enought intelligence");
            }
            else
                throw new Exception("Error");
        }

        public int getIntelligence() => Intelligence;
        public int getMoney() => Money;
        
        public delegate void MessageHandler(string Message);

        public void ShowMessage(string Message, MessageHandler Handler)
        {
            Handler(Message);
        }
        
        public new void Work()
        {
            Console.WriteLine("The program is being written...");
            _numberOfPrograms++;
            Console.WriteLine($"Congratulations!!! That is your {_numberOfPrograms} program!");
            if (SleptWell)
            {
                Console.WriteLine("Good job, you sell this program for 400 shekelei!!");
                Money += 400;
                Intelligence += 4;
                SleptWell = false;
            }
            else
            {
                Console.WriteLine("Good job, you sell this program for 200 shekelei!!");
                Money += 200;
                Intelligence += 2;
                Console.WriteLine("You could learn more if you slept well!");
            }
        }

        public int CompareTo(object o)
        {
            if (o is StudentOfPrograming s)
                return this.Money.CompareTo(s.Money);
            else
                throw new Exception("Can't compare two objects");
        }
        
        public override void Ability()
        {
            if (Intelligence >= 105)
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine("WOW! You hack the Pentagon");
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
            Console.WriteLine($"Number of written programs : {_numberOfPrograms}");
            Console.WriteLine($"The unique id : {Student.Id}");
            Console.WriteLine($"Intelligence : {Intelligence}");
            Console.WriteLine("*********************************"); 
        }
        
        delegate void IntelligenceLevel();

        public void Clever()
        {
            if (Intelligence >= 100)
            {
                Console.WriteLine("Hello, I'm clever student!");
                Work();
                Sleep(10);
                if (!SleptWell)
                    Console.WriteLine("You are tired! Go to sleep!");
            }
        }

        public void Stupid()
        {
            if (Intelligence < 100)
            {
                Console.WriteLine("Hello, I'm stupid student!");
                GoToUniversity();
            }
        }
    }
    
    
    
    public class Students
    {
        private List<StudentOfPrograming> students = new List<StudentOfPrograming>();
        public StudentOfPrograming this[int index]
        {
            get
            {
                if (index < 0 && index >= students.Count)
                {
                    throw new Exception("There is no student with this index\n");
                }
                return students[index];
            }
            set => students.Add(value);
        }
    }
    
    
    
}