using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal01
{
    internal class ConTrungBietBay : ConTrung
    {
        private int soCanh;

        public ConTrungBietBay(int id, string loai, int soChan, int soCanh) 
            : base(id, loai, soChan)
        {
            this.soCanh = soCanh;
        }

        public override void show()
        {
            base.show();

            Console.WriteLine("So Canh:"+ this.soCanh);
        }
    }
}
