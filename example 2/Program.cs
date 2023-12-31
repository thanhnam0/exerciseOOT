using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            phanso p1 = new phanso();
            Console.WriteLine("mời nhập thông tin phân số thứ 1: ");
            Console.Write("mời nhập tử số: ");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("mời nhập mẫu số: ");
            int mauso = int.Parse(Console.ReadLine());
            p1.settuso(tuso);
            p1.setmauso(mauso);
            p1.toigian();

            Console.WriteLine("mời nhập thông tin phân số thứ 2: ");
            Console.Write("mời nhập tử số: ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("mời nhập mẫu số: ");
            mauso = int.Parse(Console.ReadLine());
            phanso p2 = new phanso(tuso, mauso);
            p2.toigian();

            int chon;
            do
            {
                Console.WriteLine("===== Mời chọn các phép toán để tính =====");
                Console.WriteLine(" 1. Tổng ");
                Console.WriteLine(" 2. Hiệu ");
                Console.WriteLine(" 3. Tích ");
                Console.WriteLine(" 4. Thương ");
                Console.WriteLine(" 5. EXIT ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:

                        phanso tong = p1.cong(p2);
                        Console.WriteLine("tong cua hai phan so ps1[{0}/{1}],ps2[{2}/{3}] = [{4}/{5}]",
                            p1.gettuso(), p1.getmauso(), p2.gettuso(), p2.getmauso(), tong.gettuso(), tong.getmauso());
                        break;
                    case 2:
                        phanso hieu = p1.tru(p2);
                        Console.WriteLine("hieu cua hai phan so ps1[{0}/{1}],ps2[{2}/{3}] = [{4}/{5}]",
                            p1.gettuso(), p1.getmauso(), p2.gettuso(), p2.getmauso(), hieu.gettuso(), hieu.getmauso());
                        break;
                    case 3:
                        phanso tich = p1.nhan(p2);
                        Console.WriteLine("tich cua hai phan so ps1[{0}/{1}],ps2[{2}/{3}] = [{4}/{5}]",
                            p1.gettuso(), p1.getmauso(), p2.gettuso(), p2.getmauso(), tich.gettuso(), tich.getmauso());
                        break;
                    case 4:
                        phanso thuong = p1.chia(p2);
                        Console.WriteLine("thuong cua hai phan so ps1[{0}/{1}],ps2[{2}/{3}] = [{4}/{5}]",
                            p1.gettuso(), p1.getmauso(), p2.gettuso(), p2.getmauso(), thuong.gettuso(), thuong.getmauso());
                        break;
                    case 5:
                        goto ketthuc;
                }

            } while (chon != 5);
        ketthuc:;

            Console.WriteLine("+++++ Tính toán dãy phân số +++++");
            Console.Write(" Mời nhập số nguyên dương: ");
            int n = int.Parse(Console.ReadLine());
            phanso s = new phanso(0, 1);
            for (int i = 1; i <= n; i++)
            {
                s = s.cong(new phanso(1, i));
            }
            s.toigian();
            Console.WriteLine(" kết quả của phân số: {0}/{1}", s.gettuso(), s.getmauso());

            Console.ReadKey();
        }
    }
}
