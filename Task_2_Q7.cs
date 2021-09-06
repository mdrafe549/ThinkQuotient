//created By Sayed Md rafe

using System;

namespace Task2_Q7
{

    class ParamsEx
    {

        public static void Main_7(string[] args)
        {
            //Example for use of Params parameter
            NamesDisplay("Sayed ","Mumbai");
            NamesDisplay("Sayed", "Md Rafe", "Mumbai", "India", "8318524931");

            Console.Read();

        }

        private static void NamesDisplay(params string[] parameters)
        {
            Console.WriteLine("Employee Details are as follows:");
            
            foreach (var item in parameters)
            {
               Console.WriteLine(item);
            }

        }
    }
}
   

