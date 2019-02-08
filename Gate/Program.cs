using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gate
{
    class Program
    {
        struct  Coordinate
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] sArray = inputStr.Split(' ');

            int h = Convert.ToInt32(sArray[0]);
            int w = Convert.ToInt32(sArray[1]);
            int n = Convert.ToInt32(sArray[2]);

            Coordinate player=new Coordinate();
            player.x = 0;
            player.y = 0;
            bool isOut=false;
            for (int i = 0; i < n; i++)
            {
                string direct = Console.ReadLine();

                switch (direct)
                {
                    case "U":
                        player.y += 1;
                        break;
                    case "D":
                        player.y -= 1;
                        break;
                    case "L":
                        player.x -= 1;
                        break;
                    case "R":
                        player.x += 1;
                        break;
                }

                if(player.x<0||player.x>=h||player.y<0||player.y>=w)
                {
                    isOut = true;
                }
                
            }

            if (isOut==false)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            //Console.ReadKey();
        }
    }
}
