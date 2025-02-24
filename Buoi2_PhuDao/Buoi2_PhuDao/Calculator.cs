using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_PhuDao
{
    public class Calculator
    {
        // logic 
        public int TinhTriTuyetDoi(int number)
        {
            // khoang dieu kien : int.min -> int.max
            //0 -> int.max
            if(number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Abs(number);
        }
    }
}
