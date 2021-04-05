using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A_Military
{
    class Range : EdsonR
    {
        public string RoleinUnit
        {
            get
            {
                return RoleinUnit;
            }
            //Console.WriteLine("My Role is ");
        }

        public string WorkinUnit
        {
            get
            {
                return WorkinUnit;
            }
            //Console.WriteLine("is what I do.");

        }


        public string Equipment
        {
            get
            {
                return Equipment;
            }
            //Console.WriteLine("is used to complete the mission");
        }
    }
}
