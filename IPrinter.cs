using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    interface IPrinter
    {
        public void PrintAverage(double average);
        // public void PrintMin(int min);
        // public void PrintMax(int min);
        public void PrintBasicInfo(Student student);
        public void PrintAge(AgeStruct age);
    }
}
