using System;
using System.Collections.Generic;
using System.Text;

namespace EX7A_Military
{
    class EdsonR
    {
        public void NameData /*(string rank, string name, string section)*/
            
        {
            get
            {
                return NameData;
            }
            //Console.WriteLine($"Rank:{rank} Name:{name}");
            //Console.WriteLine($"Section:{section}");
        }

        public void RoleinUnit/*(string role)*/
        {
            get
            {
                return RoleinUnit;
            }
            //Console.WriteLine($"My Role is a {role}");
        }

        public string WorkinUnit/*(string work)*/
        {
            //Console.WriteLine($"{work} is what I do.");
            get
            {
                return WorkinUnit;
            }

        }

        public string Equipment/*(string equip)*/
        {
            get
            {
                return Equipment;
            }
            //Console.WriteLine($" {equip} is used to complete the mission");
        }
    }
}
