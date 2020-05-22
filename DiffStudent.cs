using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    class DiffStudent : Student
    {
        public FacultyType Faculty { get; }
        public SpecialityType Speciality { get; }
        public int Ticket { get; }
        public DiffStudent(string name, UniversityType university, FacultyType faculty,
            SpecialityType speciality, int rankingPlace, int[] array) : base(name, university, rankingPlace, array)
        {
            Faculty = faculty;
            Speciality = speciality;
            Ticket = GenerateID.Generate();
        }
        public override string ToString()
        {
            return base.ToString() + "\nTicket: " + Ticket + "\nFaculty: " +
                Faculty + "\nSpeciality: " + Speciality + "\nRanking place: " + RankingPlace;
        }
    }
}
