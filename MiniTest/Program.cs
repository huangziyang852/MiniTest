using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class Program
    {
        struct staff
        {
            public string name;
            public int count;
        }
        static void Main(string[] args)
        {
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            staff[] staffs = new staff[n];
            string inputStr1 = Console.ReadLine();
            string[] sArray1 = inputStr1.Split(' ');
            for(int i=0;i<n;i++)
            {
                staffs[i].name = sArray1[i];
            }
            m = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<m;i++)
            {
                string inputStr2 = Console.ReadLine();
                string[] sArray2 = inputStr2.Split(' ');
                string thisName = sArray2[0];
                int thisCount = Convert.ToInt32(sArray2[1]);
                for(int j=0;j<n;j++)
                {
                    if (staffs[j].name == thisName)
                    {
                        staffs[j].count += thisCount;
                    }

                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (staffs[j].count < staffs[j + 1].count)
                    {
                        staff empty = staffs[j];
                        staffs[j] = staffs[j + 1];
                        staffs[j + 1] = empty;
                    }
                }
            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(staffs[i].name);
            }
        }
        
    }
}
