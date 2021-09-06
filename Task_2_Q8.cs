using System;

namespace Task2_Q8
{

    class TupleExample
    {

        static void Main_10(string[] args)
        {
            //Example for use of Tuple
            var mytuple = Tuple.Create(1, "Sayed", "Mumbai", 60.02, 25000, true, "Location_Pune", "Zensar");
            Console.WriteLine(mytuple.Item1);
            Console.WriteLine(mytuple.Item2);
            Console.WriteLine(mytuple.Item3);
            Console.WriteLine(mytuple.Item4);
            Console.WriteLine(mytuple.Item5);
            Console.WriteLine(mytuple.Item6);
            Console.WriteLine(mytuple.Item7);
            Console.WriteLine(mytuple.Rest);

            //mytuple.Item1 = 2; // we cannot change value because tuple is read only

            Console.Read();

        }       
    }
}