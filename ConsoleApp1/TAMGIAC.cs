using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class TAMGIAC : HINH
    {
        private float A;
        private float B;
        private float C;
        private float D;

        public float A1 { get => this.A; set => this.A = value; }
        public float B1 { get => this.B; set => this.B = value; }
        public float C1 { get => this.C; set => this.C = value; }
        public float D1 { get => this.D; set => this.D = value; }

        public TAMGIAC() : base() { }

        public TAMGIAC(float a, float b, float c, float d) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        

         public override void Chuvitamgiac()
         {
            Console.WriteLine("Nhap A: ");
            this.A = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B: ");
            this.B = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C: ");
            this.C = float.Parse(Console.ReadLine());
            D = A + B + C;
            Console.WriteLine("Chu vi tam giac:" + D);
            Console.WriteLine(Console.ReadLine());
         }

        public override void Dientichtamgiac_vuong()
        {
            Console.WriteLine("Nhap A: ");
            this.A = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B: ");
            this.B = float.Parse(Console.ReadLine());
            D = 1/2 * (A * B);
            Console.WriteLine("Dien tich tam giac vuong:" + D);
            Console.WriteLine(Console.ReadLine());

        }
        public override void Dientichtamgiac_can()
        {
            Console.WriteLine("Nhap A: ");
            this.A = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap H: ");
            this.B = float.Parse(Console.ReadLine());
            D = 1/2 * A * B;
            Console.WriteLine("Dien tich tam giac Can:" + D);
            Console.WriteLine(Console.ReadLine());

        }
    }
}
