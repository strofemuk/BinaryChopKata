using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChopKata
{
    //Day #1:  This is easy with a LIST
    public class ListIndexOf : IChopper
    {
       public int Chop(int target, int[] listOfNumbers)
       {
            List<int> hayList = new List<int>(listOfNumbers);
            if (hayList.Contains(target))
                return hayList.IndexOf(target);
            else
                return -1;
        }
    }
}
