using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of entries: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of Devlopers and Programming Languages");
            List<Tuple<int, string>> list = new List<Tuple<int, string>>(n);
            int j = 0;
            while (j<n)
            {
                string line = Console.ReadLine();
                string[] temp = line.Split(' ');
                list.Add(new Tuple<int, string>(Convert.ToInt32(temp[0]), temp[1]));
                j++;
            }
            list.Sort();
            j = 1;
            for(int i=n-1; i>=0; i--){
                Console.WriteLine("Rank "+ j + " " + list[i].Item2);
                j++;
            }
            Console.Read();
        }
    }
}
