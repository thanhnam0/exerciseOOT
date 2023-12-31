using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    internal class phanso
    {
        private int tuso;
        private int mauso;

        public phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public phanso(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void settuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int gettuso()
        {
            return tuso;
        }
        public void setmauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getmauso()
        {
            return mauso;
        }
        public void toigian()
        {
            int uscln = Timuscln(tuso, mauso);
            tuso = tuso / uscln;
            mauso = mauso / uscln;
        }
        private int Timuscln(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            return x;
        }
        public phanso cong(phanso PS)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * PS.mauso + PS.tuso * mauso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
        public phanso tru(phanso PS)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * PS.mauso - PS.tuso * mauso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
        public phanso nhan(phanso PS)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * PS.mauso * PS.tuso * mauso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
        public phanso chia(phanso PS)
        {
            phanso kq = new phanso();
            kq.tuso = tuso * PS.mauso / PS.tuso * mauso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
    }
}
