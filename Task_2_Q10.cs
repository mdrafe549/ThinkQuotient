using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyLibrary;

namespace Task2_Q10
{

    class StudentData
    {

        public static void Main_10(string[] args)
        {
            //Example for student data entries
            int[] StudentID = new int[100];
            string[] FullName = new string [100];
            string[] CourseName = new string[100];
            string[] PhoneNo = new string[100];
            int Count = 0;
            Console.WriteLine("Enter how many entries you want to enter:");
            Count = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine("Enter StudentID:");
                    int ID =   Convert.ToInt32(Console.ReadLine());
                    StudentID[i] = ID;
                    Console.WriteLine("Enter FullName:");
                    string FN = Console.ReadLine();
                    FullName[i] = FN;
                    Console.WriteLine("Enter CourseName:");
                    string CN = Console.ReadLine();
                    CourseName[i] = CN;
                    Console.WriteLine("Enter PhoneNo:");
                    string PN = Console.ReadLine();
                    PhoneNo[i] = PN;
            }

                Console.WriteLine("Students data entered bye user: ");

                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine("ID: {0}", StudentID[i]);
                    Console.WriteLine("FullName: {0}", FullName[i]);
                    Console.WriteLine("CourseName: {0}", CourseName[i]);
                    Console.WriteLine("PhoneNo: {0}", PhoneNo[i]);

            }

            Console.Read();
        }
    }
}