using System;

namespace L8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfMarks = { 4, 9, 10, 7, 6 };
            int rank = 65;
            DiffStudent student1 = new DiffStudent("Liza", UniversityType.BSUIR, FacultyType.CSN,
                SpecialityType.CSPT, rank, arrayOfMarks);
            AgeStruct student1Age;
            InfoPrinter info = new InfoPrinter();
            student1Age.age = 17;
            student1Age.dateOfBirth = "31.08.2002";

            info.PrintBasicInfo(student1);
            info.PrintAge(student1Age);
            GradesCalculator gradesCalculator = new GradesCalculator();
            var averageMark = gradesCalculator.FindAverage(arrayOfMarks);
            gradesCalculator.FindMark += message => Console.WriteLine(message);
            gradesCalculator.FindMin(arrayOfMarks);
            gradesCalculator.FindMax(arrayOfMarks);
            info.Notify += delegate (string message)
            {
                Console.WriteLine(message);
            };
            info.PrintAverage(averageMark);
        }
    }
}
