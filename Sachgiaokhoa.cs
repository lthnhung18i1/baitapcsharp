using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Sachgiaokhoa : Sach
    {
        string tinhtrangsach;
        public Sachgiaokhoa() : base()
        {
            this.tinhtrangsach = "moi";
        }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("tinh trang sach la :");
            this.tinhtrangsach = Console.ReadLine();
        }
        public double tinhtien()
        {
            double tien = 0;
            if (this.tinhtrangsach == "moi")
                tien = base.dongia * base.soluong; 
            else
                tien = base.dongia * base.soluong * 0.5;
            return tien;
        }
        public new void intt()
        {
            Console.WriteLine("sach giao khoa co ma {0} va co gia tien la {1}", this.masach, this.tinhtien());
        }
    }
}
