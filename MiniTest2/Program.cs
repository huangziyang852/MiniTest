using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] sArray = inputStr.Split(' ');

            int[] nums=new int[4];
            nums[0] = Convert.ToInt32(sArray[0]);
            nums[1] = Convert.ToInt32(sArray[1]);
            nums[2] = Convert.ToInt32(sArray[2]);
            nums[3] = Convert.ToInt32(sArray[3]);

            for (int i = 0;i < 3;i++)
            {
                for(int j=0;j<3-i;j++)
                {
                    if(nums[j]<nums[j+1])
                    {
                        int empty = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = empty;
                    }
                }
            }
            Console.WriteLine(nums[0] * 10 + nums[2] + nums[1] * 10 + nums[3]);
            Console.ReadKey();

        }
    }
}
