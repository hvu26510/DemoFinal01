using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal01
{
    internal class ConTrung
    {
        protected int id;
        protected string loai;
        protected int soChan;

        public ConTrung()
        {
        }

        public ConTrung(int id, string loai, int soChan)
        {
            this.id = id;
            this.loai = loai;
            this.soChan = soChan;
        }
        public int getsoChan()
        {
            return this.soChan;
        }
        public int getid()
        {
            return this.id;
        }

        public string getLoai()
        {
            return this.loai;
        }

        public virtual void show()
        {
            Console.WriteLine();
            Console.WriteLine("ID: "+ this.id);
            Console.WriteLine("Loai:"+this.loai);
            Console.WriteLine("So Chan:"+this.soChan);
          
        }

        public void nhapThongTin()
        {
            Console.WriteLine("ID: ");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Loai:");
            this.loai = Console.ReadLine();
            Console.WriteLine("So Chan:");
            try
            {
                this.soChan = NhapSoChan();
            }catch (SoChanException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (this.soChan <= 0 || (this.soChan % 2 != 0))
                {
                    this.soChan = 4;
                    Console.WriteLine("So chan da duoc dat la 4");
                }
            }
               
        }

        public int NhapSoChan()
        {
            int x = 0;
            x = int.Parse(Console.ReadLine());
            if (x <= 0 || (x % 2 != 0))
            {
                throw new SoChanException("So chan phai > 0 va la so chan");
            }
            return x;
        }

       
    }
}
