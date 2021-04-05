using System;

namespace EX7A_Military
{
    class Program
    {
        static void createHQ()
        {
            HQ JoeDoe = new HQ();
            JoeDoe.NameData("Cpl", "Joe Doe", "HQ");
            JoeDoe.RoleinUnit("Adminiatrative SP");
            JoeDoe.WorkinUnit("Page 11's");
            JoeDoe.Equipment("Computure");
        }

        static void createRange()
        {
            Range JillHill = new Range();
            JillHill.NameData("LCpl", "Jill Hill", "Range");
            JillHill.RoleinUnit("Coach");
            JillHill.WorkinUnit("Teach Marines How to qual on the range");
            JillHill.Equipment("M16 Riffle and RCO");
        }

        static void createField()
        {
            Field BillKill = new Field();
            BillKill.NameData("Sgt", "Bill Kill", "Field");
            BillKill.RoleinUnit("Instructor");
            BillKill.WorkinUnit("Show recurits survival skills in the field ");
            BillKill.Equipment("obsticale course");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is the Inside of Edson Range Unit\n");
            createHQ();
            Console.WriteLine();
            createRange();
            Console.WriteLine();
            createField();

        }
    }
}
