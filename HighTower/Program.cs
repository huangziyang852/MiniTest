using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            List<string> inputStr = new List<string>();
            for(int i=0;i<n;i++)
            {
                inputStr.Add(Console.ReadLine());
            }
            string str = inputStr[0];
            for (int i = 0; i < n-1; i++)
            {
                
                str=string_check(str,inputStr[i+1]);

                //Console.WriteLine(str);
            }
            Console.WriteLine(str);
            Console.ReadKey();
            

        }
        public static string string_check(string str1, string str2)
        {
            string outputStr = "";
            if (str2.Length <= str1.Length)
            {
                //Console.WriteLine("str1的长度" + str1.Length);
                //Console.WriteLine("str2的长度" + str2.Length);
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2.Substring(0, str2.Length- i) == str1.Substring(str1.Length-(str2.Length-i),str2.Length-i))
                    {
                        outputStr = str1 + str2.Substring(str2.Length - i, i);

                        break;
                    }
                    else
                    {
                        outputStr = str1 + str2;

                    }
                    
                }
            }
            else
            {
                //Console.WriteLine("str1的长度"+str1.Length);
                for(int i=0;i<str1.Length;i++)
                {
                    if(str2.Substring(0,str1.Length-i)==str1.Substring(i,str1.Length-i))
                    {
                        outputStr = str1 + str2.Substring(str1.Length-i,str2.Length-(str1.Length-i));
                        Console.WriteLine(1);
                        break;
                    }
                    else
                    {
                        outputStr = str1 + str2;
                        Console.WriteLine(3);
                    }
                }
            }
            
            
            return outputStr;
        }

    }
}
