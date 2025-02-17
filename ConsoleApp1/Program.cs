using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            Console.Write("mas:");
            foreach (int item in mas)
            {
                Console.Write(item + " ");
            }
            
            Console.ReadKey();
        }
    }
}
