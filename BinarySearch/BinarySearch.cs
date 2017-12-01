using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearch
    {
        public static int DoSearch(int[] array, int number, int min, int max)
        {
            int mid = max / 2;
            if (array[mid] == number)
                return mid;
            if(array[mid] > number)
            {
                max = mid +1;
            }
            else
            {
                min = mid-1;
            }
            return DoSearch(array, number, min, max);

        }
    }
}
