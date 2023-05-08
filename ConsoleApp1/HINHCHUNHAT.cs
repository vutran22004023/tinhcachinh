using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class HINHCHUNHAT:HINH
    {
        private float A;
        private float B;
        private float C;

        public float A1 { get => this.A; set => this.A = value; }
        public float B1 { get => this.B; set => this.B = value; }
        public float C1 { get => this.C; set => this.C = value; }

        public HINHCHUNHAT(): base () { }

        public HINHCHUNHAT(float a, float b, float c): base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap chieu dai:");
            this.A = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            this.A = float.Parse(Console.ReadLine());
        }

        public override void chuvi()
        {
            C = 2 * (A + B);
            Console.WriteLine("Chu vi hinh chu nhat = " + C);
            Console.WriteLine(Console.ReadLine());
        }

        public override void dientich()
        {
            C = A * B;
            Console.WriteLine("Dien tich hinh chu nhat = " + C);
            Console.WriteLine(Console.ReadLine());
        }
    }
}
