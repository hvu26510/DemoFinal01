using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.addDemoData();

            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1: Nhap danh sach");
                Console.WriteLine("2: Xuat danh sach");
                Console.WriteLine("3: Tim theo so chan");
                Console.WriteLine("4: Xoa theo ID");
                Console.WriteLine("5: Sap xep danh sach theo ten loai");
                Console.WriteLine("6: Update by ID");
                Console.WriteLine("7: Ke thua");
                Console.WriteLine("0: Thoat");

                string str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }

                switch (str)
                {
                    case "1":
                        {
                            Service.nhap();
                            break;
                        }
                    case "2":
                        {
                            Service.xuat();
                            break;
                        }
                    case "3":
                        {
                            Service.FindBySoChan();
                            break;
                        }
                    case "4":
                        {
                            Service.DeleteByID();
                            break;
                        }
                    case "5":
                        {
                            Service.Sortting();
                            break;
                        }
                    case "6":
                        {
                            Service.UpdateByID();
                            break;
                        }
                    case "7":
                        {
                            KeThua();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Khong co chuc nang");
                            break;
                        }
                }


            } while (true);

            Console.ReadLine();
        }

        static void KeThua()
        {
            ConTrungBietBay ctbb = new ConTrungBietBay(5, "Chuon Chuon", 4, 4);
            ctbb.show();
        }
    }
}
