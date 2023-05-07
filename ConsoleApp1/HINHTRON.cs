using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class HINHTRON:HINH
    {
        private float R;
        private float A;
        private float B;
        public const float M = (float)Math.PI;

        public float R1 { get => this.R; set =>this.R = value; }
        public float A1 { get => this.A; set => this.A = value; }
        public float B1 { get => this.B; set => this.B = value; }

        public HINHTRON(): base()
        {

        }

        public HINHTRON(float r, float a, float b):base()
        {
            this.R = r;
            this.A = a;
            this.B = b;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap Ban Kinh:");
            this.R = float.Parse(Console.ReadLine());
        }

        public override void Chuvihinhtron()
        {

            B = (R * 2) * M;
            Console.WriteLine("Chu vi hinh tron ={0}" + B);
        }

        public override void Dientichhinhtron()
        {
            B = R * R * M;
            Console.WriteLine("Dien Tich hinh tron ={0}" + B);
        }
    }
}
