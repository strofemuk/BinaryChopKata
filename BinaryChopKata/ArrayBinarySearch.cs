using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChopKata
{
    //Day #2: This can also be done with the System.Array object functions
    public class ArrayBinarySearch : IChopper
    {
        public int Chop(int target, int[] listOfNumbers)
        {
            if (listOfNumbers.Contains(target))
                return Array.BinarySearch(listOfNumbers, target);
            else
                return -1;
        }
    }
}
