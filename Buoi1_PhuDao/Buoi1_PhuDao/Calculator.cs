using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_PhuDao
{
    public class Calculator
    {
        // tinh tong, hieu, tich, thuong
        public int TinhTong(int a, int b)
        {
            return a + b;
        }

        public int TinhHieu(int a, int b)
        {
            return a - b;
        }

        public int TinhTich(int a, int b)
        {
            return a * b;
        }

        public double TinhThuong(int a, int b)
        {
            return (double)a / b;
        }
        
        // Tinh can bac hai 
        public double TinhCanBacHai(int number)
        {
            if(number < 0)
            {
                // Khong tinh duoc can bac 2 
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(number);
        }
    }
}
