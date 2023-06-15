using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal01
{
    internal static class Service
    {
        static List<ConTrung> listConTrung = new List<ConTrung>();

        public static void addDemoData()
        {
            ConTrung ct1 = new ConTrung(1, "Chau Chau", 6);
            ConTrung ct2 = new ConTrung(2, "Chuon chuon",4);
            ConTrung ct3 = new ConTrung(3, "Nhen", 8);
            
            listConTrung.Add(ct3);
            listConTrung.Add(ct1);
            listConTrung.Add(ct2);

        }

        public static void xuat()
        {
            foreach(ConTrung ct in listConTrung)
            {
                ct.show();
            }
        }

        public static void nhap()
        {
            do
            {
                ConTrung ct = new ConTrung();
                ct.nhapThongTin();

                listConTrung.Add(ct);

                Console.WriteLine("Tiep tuc? nhap y de tiep tuc");
                if(Console.ReadLine() != "y")
                {
                    break;
                }
            }while(true);
        }
        public static void FindBySoChan()
        {
            Console.WriteLine("Nhap so chan muon tim:");
            int sochan = int.Parse(Console.ReadLine());
            foreach(ConTrung ct in listConTrung)
            {
                if(ct.getsoChan() == sochan)
                {
                    ct.show();
                }
            }

        }

        public static void DeleteByID()
        {
            Console.WriteLine("Nhap ID muon Xoa:");
            int id = int.Parse(Console.ReadLine());
            foreach (ConTrung ct in listConTrung)
            {
                if (ct.getid() == id)
                {
                    listConTrung.Remove(ct);
                    break;
                }
            }

        }

        public static void Sortting()
        {
            listConTrung.Sort((x,y)=>x.getLoai().CompareTo(y.getLoai()));

            //List<ConTrung> newList = listConTrung.OrderBy(ct=>ct.getLoai()).ToList();
            //foreach(ConTrung ct in newList)
            //{
            //    ct.show();
            //}
        }
        public static void UpdateByID()
        {
            Console.WriteLine("Nhap ID muon update:");
            int id = int.Parse(Console.ReadLine());
            foreach (ConTrung ct in listConTrung)
            {
                if (ct.getid() == id)
                {
                    ct.nhapThongTin();
                    break;
                }
            }

            //ConTrung conTrung = listConTrung.Where(ct1=> ct1.getid() == id).FirstOrDefault();            
            //int index = listConTrung.IndexOf(conTrung);
            //listConTrung[index].nhapThongTin();

        }


    }
}
