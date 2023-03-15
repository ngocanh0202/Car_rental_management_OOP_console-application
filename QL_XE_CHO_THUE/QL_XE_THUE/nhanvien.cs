using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class nhanvien :  nguoi
    {
        string manhanvien;
        DateTime ngayvaocoquan;

        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public DateTime Ngayvaocoquan { get => ngayvaocoquan; set => ngayvaocoquan = value; }

        public nhanvien() { }
        public nhanvien(long sochungminh, string hoten, string diachi, string dienthoai, string manhanvien, DateTime ngayvaocoquan)
            : base(sochungminh, hoten, diachi, dienthoai)
        {
            this.manhanvien = manhanvien;
            this.ngayvaocoquan = ngayvaocoquan;
        }

        public override void nhap()
        {
            Console.WriteLine("Nhap thong tin nhan vien");
            Console.WriteLine("Nhap ma nhan vien : ");
            manhanvien = Console.ReadLine();
            base.nhap();
            Console.WriteLine("Nhap ngay vao co quan : ");
            do
            {
                try
                {
                    ngayvaocoquan = DateTime.Parse(Console.ReadLine());
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
            Console.WriteLine("Thong tin nhan vien ");
            Console.WriteLine("Ma nhan vien : " + manhanvien);
            base.xuat();
            Console.WriteLine("Ngay vao co quan : " + ngayvaocoquan);
        }
    }
}
