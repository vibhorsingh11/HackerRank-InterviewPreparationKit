using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit.Warm_Up
{
    class JumpingOnTheClouds
    {
        public static void Entry()
        {
            int[] c = { 0, 0, 1, 0, 0, 1, 0 };
            JumpingOnTheClouds obj = new JumpingOnTheClouds();
            obj.jumpingOnClouds(c);
        }

        public void jumpingOnClouds(int[] c)
        {
            int n = c.Length;
            int count = -1;
            for (int i = 0; i < n; i++, count++)
            {
                if (i < n - 2 && c[i + 2] == 0) i++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
