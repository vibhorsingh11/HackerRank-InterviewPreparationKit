using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit.Warm_Up
{
    class CountingValleys
    {
        public static void Entry()
        {
            int[] c = { 0, 0, 1, 0, 0, 1, 0 };
            CountingValleys obj = new CountingValleys();
            obj.jumpingOnClouds(c);
        }

        public void CountingValley(int[] c)
        {
            char[] charArry = s.ToCharArray();
            int mountain = 0; int valley = 0; int count = 0;
            for (int i = 0; i < charArry.Length; i++)
            {
                if (charArry[i] == 'U')
                {
                    if (valley != 0)
                    {
                        valley--;
                        if (valley == 0)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        mountain++;
                    }
                }
                else
                {
                    if (mountain != 0)
                    {
                        mountain--;
                    }
                    else
                    {                       
                        valley++;
                        if (valley == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
