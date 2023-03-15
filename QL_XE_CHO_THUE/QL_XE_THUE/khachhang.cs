using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class khachhang : nguoi
    {
        string makhachhang;
        DateTime hangbanglai;

        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public DateTime Hangbanglai { get => hangbanglai; set => hangbanglai = value; }

        public khachhang() { }
        public khachhang(long chungminhthu, string hoten, string diachi, string dienthoai, string makhachhang, DateTime hangbanglai) 
            : base(chungminhthu,hoten,diachi,dienthoai)
        {
            this.makhachhang = makhachhang;
            this.hangbanglai = hangbanglai;
        }

        public override void nhap()
        {
            Console.WriteLine("Nhap thong tin khach hang ");
            Console.WriteLine("Nhap ma khach hang : ");
            makhachhang = Console.ReadLine();
            base.nhap();
            Console.WriteLine("Nhap hang bang lai : ");
            do
            {
                try
                {
                    hangbanglai = DateTime.Parse(Console.ReadLine());
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
            Console.WriteLine("Thong tin khach hang ");
            Console.WriteLine("Ma khach hang : " + makhachhang);
            base.xuat();
            Console.WriteLine("Hang bang lai : " + hangbanglai);
        }
    }
}
