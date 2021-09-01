using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
              //Dictionary Key and Values
                {"id1","Apple" },
                {"id2","Banana" },
                {"id3","Litchi" },
                {"id4","Grape" },
                {"id5","Mango" },
                {"id6","Guava" },
                {"id7","Pear" },
                {"id8","Coconut" },
                {"id9","Papaya" },
                {"id10","Strawberry" }
            };
            string id = "id11";
            bool keyExists = dict.ContainsKey(id);
            if (keyExists)
            {
               
                //dictionary Remove(key);
                Console.WriteLine("key is found",id);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("key does not found", id);
                Console.ReadLine();
            }
        }
    }
}