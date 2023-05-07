using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static DANHSACHCACHINH ds;


        static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\x1b[96m-----------------------------------------------");
                Console.WriteLine("| Nhap tu 1-3 de thuc hien cac chuc nang sau: |");
                Console.WriteLine("| 1. Tam giac                              |");
                Console.WriteLine("| 2. Hinh chu nhat                         |");
                Console.WriteLine("| 3. Hinh tron                             |");
                Console.WriteLine("-----------------------------------------------\x1b[0m");
                int menu = 0;
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            ds.tamgiac();
                            break;
                        }
                    case 2:
                        {
                            ds.hinhchunhat();
                            break;
                        }

               
                    default:
                        Console.WriteLine("Yeu cau nhap chuc nang menu  tu 1-3");
                        Menu();
                        break;
                }//end switch
            }
            catch (Exception ex)
            {
                Menu();
            }
        }

        static void Main(string[] args)
        {

            ds = new DANHSACHCACHINH();
            char c = 'y';
            while (c == 'y')
            {
                Menu();
                Console.WriteLine("Nhap ky tu 'y' de tro ve menu");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
    }
}
