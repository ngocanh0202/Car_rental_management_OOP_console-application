using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class xechohang : xe
    {
        double sotan;

        public double Sotan { get => sotan; set => sotan = value; }

        public xechohang() {  }
        public xechohang(string bienxe, string tenxe, int trongtai, DateTime ngaydangkiem, int tieuchuanbang, double sotan) :
            base(bienxe, tenxe, trongtai, ngaydangkiem, tieuchuanbang)
        {
            this.sotan = sotan;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap thong tin xe cho hang : ");
            base.nhap();
            Console.WriteLine("Nhap so tan : ");
            do
            {
                try
                {
                    sotan = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai");
                }
            } while (true);
        }
        public override void xuat()
        {
            Console.WriteLine("Thong tin xe cho hang : ");
            base.xuat();
            Console.WriteLine("So tan : " + sotan);
        }
    }
}
