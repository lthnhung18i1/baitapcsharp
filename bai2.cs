using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b2
{
    class doantau
    {
        string matau;
        int sokhach;
        public void nhap()
        {
            Console.WriteLine("nhap ma doan tau");
            this.matau = Console.ReadLine();
            Console.WriteLine("nhap so khach");
            this.sokhach = Convert.ToInt32(Console.ReadLine());
        }
        public int tinhtien()
        {
            int tien;
            if(this.sokhach < 100) tien = this.sokhach * 100000;
            else tien = this.sokhach * 80000;
            return tien;
        }
        public void intt()
        {
            Console.WriteLine(" doan tau co ma {0} co tien la {1}", this.matau, this.tinhtien());
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so doan tau");
            n=Int32.Parse(Console.ReadLine());
            doantau[] mangdt=new doantau[100];
            for (int i=1;i <n; i++)
            {
                mangdt[i]=new doantau();
                mangdt[i].nhap();
                mangdt[i].intt();
            }
            doantau tau1=new doantau();
            tau1.nhap();
            tau1.intt();
            Console.ReadLine();

        }
    }
}
