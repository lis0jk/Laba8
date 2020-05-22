using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    class GenerateID
    {
        public static int ID;
        public static int Generate()
        {
            Random random = new Random();
            ID = random.Next(1000000, 99999999);
            return ID;
        }
    }
}
