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
            
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Hinh: " + tenHinh);
        }

        public virtual void Chuvitamgiac()
        {

        }
        public virtual void Dientichtamgiac_vuong()
        {

        }
        public virtual void Dientichtamgiac_can()
        {

        }

        public virtual void chuvi()
        {

        }

        public virtual void dientich()
        {

        }

        public virtual void Chuvihinhtron()
        {

        }

        public virtual void Dientichhinhtron()
        {

        }
    }


}
