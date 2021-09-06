using System;
using System.Collections.Generic;


namespace Task2_Q9
{

    class ExceptionHandling
    {

        public static void Main(string[] args)
        {
            //Example for Exception handling using array for 5 students names
            string[] student = new string[5];
            string name;
            try
            {
                Console.WriteLine("Enter Student Names:");

                for (int i = 1; i <= 5; i++)
                {
                    name = Console.ReadLine();
                    student[i] = name;
                }

                Console.WriteLine("Array of students entered bye user: ");

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(student[i]);
                   
                }

                //Console.WriteLine("Enter Student Names:");
                name = Console.ReadLine();
                student[6] = name;
                

            }

            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);

            }

            catch (Exception)
            {

                Console.WriteLine("error 404:x - array size is full. exception is handled");


            }
        

            Console.Read();
        }
    }
}