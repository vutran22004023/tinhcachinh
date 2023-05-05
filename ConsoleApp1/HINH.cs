using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class HINH
    {
        protected string tenHinh;

        public string TenHinh { get => this.tenHinh; set => this.tenHinh = value; }

        public HINH(){}

        public HINH (string tenHinh)
        {
            this.TenHinh = tenHinh;
        }

        public virtual void Nhap ()
        {
            Console.WriteLine("Nhap Hinh :");
            this.tenHinh = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Hinh: " + tenHinh);
        }
        
    }


}
