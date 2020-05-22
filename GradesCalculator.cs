using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    class GradesCalculator
    {
        public delegate void MarkHendler(string mess);
        public event MarkHendler FindMark;
        public void FindMin(int[] array)
        {
            Array.Sort(array, 0, array.GetLength(0));
            var result = array[0];
            FindMark?.Invoke($"Min mark was found: {result}");
            //return result;
        }
        public void FindMax(int[] array)
        {
            Array.Sort(array, 0, array.GetLength(0));
            var result = array[array.GetLength(0) - 1];
            FindMark?.Invoke($"Max mark was found: {result}");
            // return result;

        }
        public double FindAverage(int[] array)
        {
            Array.Sort(array, 0, array.GetLength(0));
            int buf = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                buf += array[i];
            }
            var result = buf / array.GetLength(0);
            return result;
        }
    }
}
