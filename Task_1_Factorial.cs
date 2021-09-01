using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialprogram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, fact = 1, number;

            //To take input from users

            Console.Write("enter number");
            number = int.Parse(Console.ReadLine());
            Console.Read();
            //Loop for iteration of every number
            for(i=1;i<=number;i++)
            {
             //Function for getting factors of each number
                fact=fact*i;
            }
            Console.Write("factorial of" + number + "is"+fact);
            Console.Read();

        }
    }
}
