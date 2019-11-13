using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit.Warm_Up
{
    class SockMerchant
    {
        public static void Entry()
        {
            int[] c = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            SockMerchant obj = new SockMerchant();
            obj.SocksMerchant(9, c);
        }

        public void SocksMerchant(int n, int[] ar)
        {
            HashSet<int> hash = new HashSet<int>();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (!hash.Contains(ar[i]))
                {
                    hash.Add(ar[i]);
                }
                else
                {
                    count++;
                    hash.Remove(ar[i]);
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
