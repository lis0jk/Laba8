using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    class InfoPrinter : IPrinter
    {
        public delegate void Hendler(string message);
        public event Hendler Notify;
        public void PrintAverage(double average)
        {
            Notify?.Invoke("\nMethod 'FindAverage' worked\nPrinting average mark");
            Console.WriteLine($"Average mark: {average}\n ");
        }
        /* public void PrintMin(int min)
         {
             Console.WriteLine($"Min mark: {min}");
         }
         public void PrintMax(int max)
         {
             Console.WriteLine($"Max mark: {max}");
         }*/
        public void PrintBasicInfo(Student student)
        {
            if (student.RankingPlace > 183 || student.RankingPlace < 1)
            {
                throw new Exception("Ranking place is not in the range");
            }
            foreach (char c in student.Name)
            {
                if (!Char.IsLetter(c))
                {
                    throw new Exception("Name contains some wierd symbols");
                }
            }
            Console.WriteLine(student.ToString());
        }
        public void PrintAge(AgeStruct age)
        {

            if (age.dateOfBirth.Length != 10)
            {
                throw new Exception("Wrong format of the birth date");
            }
            Console.WriteLine($"Date of birth: {age.dateOfBirth}" +
            $"\nFull years: {age.age}\n");

        }
    }
}
