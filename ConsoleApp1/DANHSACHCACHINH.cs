using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class DANHSACHCACHINH
    {
        Dictionary<String, HINH> listStaff;
        public DANHSACHCACHINH()
        {
            this.listStaff = new Dictionary<string, HINH>();
        }

        public void tamgiac()
        {
            char c = 'y';
            while (c == 'y')
            {
                HINH h = null;
                char loai = ' ';
                
                Console.WriteLine("C. Chu vi tam giac");
                Console.WriteLine("V. Dien tich tam giac vuong");
                Console.WriteLine("M. Dien tich tam giac  tam giac can");
                Console.WriteLine("T. Thoat");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'C':
                        {
                            h = new TAMGIAC();
                            
                            h.Chuvitamgiac();
                            break;
                        }
                    case 'V':
                        {
                            h = new TAMGIAC();
                            
                            h.Dientichtamgiac_vuong();
                            break;
                        }
                    case 'M':
                        {
                            h = new TAMGIAC();
                            
                            h.Dientichtamgiac_can();
                            break;
                        }
                    
                }//end switch
                if (h != null)
                    this.listStaff.Add(h.TenHinh, h);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }// end while
        }//end Tam giac



        public void hinhchunhat()
        {
            char c = 'y';
            while (c == 'y')
            {
                HINH h = null;
                char loai = ' ';
                
                Console.WriteLine("C. Chu vi hinh chu nhat");
                Console.WriteLine("V. Dien tich hinh chu nhat");
                Console.WriteLine("T. Thoat");

                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'C':
                        {
                            h = new HINHCHUNHAT();
                            h.Nhap();
                            h.chuvi();
                            break;
                        }
                    case 'V':
                        {
                            h = new HINHCHUNHAT();
                            h.Nhap();
                            h.dientich();
                            break;
                        }
                    

                }//end switch
                if (h != null)
                    this.listStaff.Add(h.TenHinh, h);
                    Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }// end while
        }// end hinh chu nhat

        public void hinhtron()
        {
            char c = 'y';
            while (c == 'y')
            {
                HINH h = null;
                char loai = ' ';
                Console.WriteLine("C. Chu vi hinh tron");
                Console.WriteLine("D. Dien tich hinh tron");
                Console.WriteLine("T. Thoat");

                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'C':
                        {
                            h = new HINHTRON();
                            h.Nhap();
                            h.Chuvihinhtron();
                            break;
                        }
                    case 'V':
                        {
                            h = new HINHTRON();
                            h.Nhap();
                            h.Dientichhinhtron();
                            break;
                        }
                    
                }//end switch
                if (h != null)
                    this.listStaff.Add(h.TenHinh, h);
                Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }// end while
        }// end hinh chu nhat
    }
}
