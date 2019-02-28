using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai1
{
    class tinhtong
    {
        static int tong1(int n)
        {
            int a = 0, b = 0, s1 = 0;
            for (int i = 0; i <= n; i = i + 2) a = a + i;
            for (int j = 1; j <= n; j = j + 2) b = b + j;
            s1 = b - a;
            return s1;
        }
        static float tong2(int n)
        {
            float s2 = 0 ;
            for(int i = 1; i<=n; i++) s2 = s2 + 1/i;
            return s2;
        }
        static int tong3(int n)
        {
            int s3 = 0 ;
            for (int i = 1; i<=n; i++) s3 = s3 + i;
            return s3;
        }
        static int tong4(int n)
        {
            int s4 = 0 ;
            for ( int i = 1; i<=n; i++)
            { if (n%i==0) s4+=i;
            }
            return s4;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap vao n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("s1 la {0}", tong1(n));
            Console.WriteLine("s2 la {0}", tong2(n));
            Console.WriteLine("s3 la {0}", tong3(n));
            Console.WriteLine("s4 la {0}", tong4(n));
            Console.ReadLine();
        }
    }
}
