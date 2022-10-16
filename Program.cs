using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //倒星形三角形
            for (int i = 1; i <= 5; i++)
            {
                string value = new string('*', i) + new string(' ', 5 - i);
                Console.WriteLine(value);
            }
            ////倒星形三角形2
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = i; j <= 5; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
