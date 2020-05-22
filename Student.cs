using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    class Student : Human
    {
        public UniversityType University { get; }
        public int RankingPlace { get; }

        public Student(string name, UniversityType university, int rankingPlace, int[] array) : base(name)
        {
            University = university;
            RankingPlace = rankingPlace;

        }
        public override string ToString()
        {
            return "Name: " + Name + "\nUniversity: " + University;
        }
    }
}
