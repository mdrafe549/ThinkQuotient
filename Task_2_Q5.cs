using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Task2_Q5
    {
        static void Main(string[] args)
        {
            SortedList<int , string> sl = new SortedList<int , string>();

            sl.Add(1200,"CSharp");
            sl.Add(1400,"Python");
            sl.Add(456,"Java");
            sl.Add(1900,"JavaScript");
            sl.Add(1500,"SQL");
            
            Console.WriteLine("Sorted List: ");
            foreach (int s in sl.Keys)
                Console.WriteLine(s + ": " + sl[s]);  
                
        }
    }
}    
