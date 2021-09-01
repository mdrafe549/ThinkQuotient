using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace TaskQ4{
     class Program  {
             static void Main(string[] args) {
                     Console.WriteLine("What is your number for day? (1 - 7)?");   
                           int num_day = int.Parse(Console.ReadLine());

            switch (num_day)

            {
                case 1:

                    {
                        Console.WriteLine("This is Monday!");

                        break;
 

                    }

                case 2:

                    {

                        Console.WriteLine("This is Tuesday!");

                        break;

                    }

                case 3:

                    {

                        Console.WriteLine("This is Wednesday!");

 

                        break;
                    }

                case 4:

                    {

                        Console.WriteLine("This is Thursday!");

                        break;

                    }

                case 5:

                    {

                        Console.WriteLine("This is Friday!");

                        break;
                    }

                case 6:

                    {

                        Console.WriteLine("This is Saturday!");

                        break;
                    }

                case 7:

                    {

                        Console.WriteLine("This is Sunday!");

                       break;

                    }

                default:

                    {

                        Console.WriteLine("Enter correct days value!");

                        break;

                    }

            }

            Console.ReadLine();

        }

    }

}

