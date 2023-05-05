using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class TAMGIAC :HINH
    {
        private float A;
        private float B;
        private float C;

        public float A1 { get => this.A; set => this.A = value; }
        public float B1 { get => this.B; set => this.B = value; }
        public float C1 { get => this.C; set => this.C = value; }

        public TAMGIAC(): base() { }

        public TAMGIAC(float a, float b, float c): base()
        {
            A = a;
            B = b;
            C = c;
            
        }
    }
}
