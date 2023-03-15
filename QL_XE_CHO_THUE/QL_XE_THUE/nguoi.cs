using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    abstract class nguoi
    {
        long sochungminh;
        string hoten;
        string diachi;
        string dienthoai;

        public long Sochungminh { get => sochungminh; set => sochungminh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }

        public nguoi() { }
        public nguoi(long sochungminh, string hoten, string diachi, string dienthoai)
        {
            this.sochungminh = sochungminh;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
        }

        public virtual void nhap()
        {
            Console.WriteLine("Nhap so chung minh :");
            do
            {
                try
                {
                    sochungminh = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai");
                }
            } while (true);
            Console.WriteLine("Nhap ho ten :");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi :");
            diachi = Console.ReadLine();
            Console.WriteLine("Nhap dien thoai : ");
            dienthoai = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("So chung minh : " + sochungminh);
            Console.WriteLine("Ho ten : " + hoten);
            Console.WriteLine("Dia chi : " + diachi);
            Console.WriteLine("Dien Thoai : " + dienthoai);
        }
    }
}
