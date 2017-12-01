using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 13, 22, 49, 100, 283, 289, 300 };
            Console.WriteLine(BinarySearch.DoSearch(array, 22, 0, array.Length-1));
            Console.Read();
        }
    }
}
