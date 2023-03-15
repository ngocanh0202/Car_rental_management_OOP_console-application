using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class xedulich : xe
    {
        int sochongoi;
        public int Sochongoi { get => sochongoi; set => sochongoi = value; }
        public xedulich() {  }
        public xedulich(string bienxe, string tenxe, int trongtai, DateTime ngaydangkiem, int tieuchuanbang, int sochongoi) 
            : base(bienxe, tenxe, trongtai, ngaydangkiem, tieuchuanbang)
        {
            this.Sochongoi = sochongoi;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap thong tin xe du lich : ");
            base.nhap();
            Console.WriteLine("Nhap so cho ngoi : ");
            do
            {
                try
                {
                    Sochongoi = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Thong tin xe du lich");
            base.xuat();
            Console.WriteLine("So cho ngoi" + sochongoi);
        }
    }
}
