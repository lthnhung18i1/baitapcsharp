using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Sach
    {
        protected string masach;
        protected String ngaynhap;
        protected double dongia;
        protected double soluong;
        public Sach()
        {
            this.masach = "p00";
            this.ngaynhap = "00/00/0000";
            this.dongia = 1000000;
            this.soluong = 100;
        }

        public void nhap()
        {
            Console.WriteLine("nhap ma sach");
            this.masach = Console.ReadLine();
            Console.WriteLine("nhap ngay nhap sach");
            this.ngaynhap = Console.ReadLine();
            Console.WriteLine("nhap don gia");
            this.dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong sach");
            this.soluong = double.Parse(Console.ReadLine());
        }
        public void intt()
        {
            Console.WriteLine("sach co ma la {0}\n co ngay nhap la {1}\n co don gia la {2}\n co so luong la {3}", this.masach, this.ngaynhap, this.dongia, this.soluong);
        }
    }
}
