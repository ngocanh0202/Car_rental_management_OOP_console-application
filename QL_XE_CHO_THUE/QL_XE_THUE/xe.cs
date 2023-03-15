using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    abstract class xe
    {
        string bienxe;
        string tenxe;
        int trongtai;
        DateTime ngaydangkiem;
        int tieuchuanbang;

        public string Bienxe { get => bienxe; set => bienxe = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public int Trongtai { get => trongtai; set => trongtai = value; }
        public DateTime Ngaydangkiem { get => ngaydangkiem; set => ngaydangkiem = value; }
        public int Tieuchuanbang { get => tieuchuanbang; set => tieuchuanbang = value; }

        public xe() {  }
        public xe(string bienxe, string tenxe, int trongtai, DateTime ngaydangkiem, int tieuchuanbang)
        {
            this.bienxe = bienxe;
            this.tenxe = tenxe;
            this.trongtai = trongtai;
            this.ngaydangkiem = ngaydangkiem;
            this.tieuchuanbang = tieuchuanbang;
        }
        public virtual void nhap()
        {
            Console.WriteLine("Nhap bien xe: ");
            this.bienxe = Console.ReadLine();
            Console.WriteLine("Nhap ten xe: ");
            this.tenxe = Console.ReadLine();
            Console.WriteLine("Nhap trong tai: ");
            do
            {
                try
                {
                    this.trongtai = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai");
                }
            } while (true);
            Console.WriteLine("Nhap ngay dang kiem : ");
            do
            {
                try
                {
                    this.ngaydangkiem = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai");
                }
            } while (true);
            Console.WriteLine("Nhap tieu chuan bang : ");
            do
            {
                try
                {
                    this.tieuchuanbang = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai");
                }
            } while (true);
        }
        public virtual void xuat()
        {
            Console.WriteLine("Bien xe : " + bienxe);
            Console.WriteLine("Ten xe : " + tenxe);
            Console.WriteLine("Trong tai : " + trongtai);
            Console.WriteLine("Ngay Dang kiem : " + Ngaydangkiem);
            Console.WriteLine("Tieu Chuan bang : " + tieuchuanbang);
        }
    }
}