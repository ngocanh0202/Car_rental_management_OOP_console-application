using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class lophongchothue 
    {
        string sohopdong;
        xe xe;
        nguoi khachhang;
        nguoi nhanvien;
        int songaythue;
        double dongia;
        DateTime ngaythue;

        public string Sohopdong { get => sohopdong; set => sohopdong = value; }
        public int Songaythue { get => songaythue; set => songaythue = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        internal xe Xe { get => xe; set => xe = value; }
        internal nguoi Khachhang { get => khachhang; set => khachhang = value; }
        internal nguoi Nhanvien { get => nhanvien; set => nhanvien = value; }
        internal qlxe Qlx { get => qlx; set => qlx = value; }

        qlxe qlx;
        public lophongchothue() 
        {
            Qlx = new qlxe();
        }
        
        public double thanhtien()
        {
            return dongia * songaythue;
        }
        public double dongiachoxe(xe x)
        {
            if (x is xechohang)
            {
                return 500000;
            }
            else if (x is xedulich)
            {
                xedulich a = x as xedulich;
                if (a.Sochongoi <= 5)
                {
                    return 500000;
                }
                else if (a.Sochongoi <= 7)
                    return 700000;
                else
                {
                    return 1000000;
                }
            }
            return 0;
        }
        public void Nhap()
        {
            Qlx.nhap();
            Console.WriteLine("Nhap thong tin bien xe :");
            string bienso = Console.ReadLine();
            xe = Qlx.tim(bienso);
            if(xe != null)
            {
                nhanvien = new nhanvien();
                nhanvien.nhap();
                khachhang = new khachhang();
                khachhang.nhap();
                Console.WriteLine("So hop dong : ");
                sohopdong = Console.ReadLine();
                Console.WriteLine("So ngay thue : ");
                do
                {
                    try
                    {
                        songaythue = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nhap sai");
                    }
                } while (true);
                dongia = dongiachoxe(xe);
                Console.WriteLine("Don gia : " + dongia);
                Console.WriteLine("Nhap ngay thue : ");
                do
                {
                    try
                    {
                        ngaythue = DateTime.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nhap sai");
                    }
                } while (true);
            }
            else
            {
                Console.WriteLine("khong co xe");
            }
        }
        public void Xuat()
        {
            xe.xuat();
            nhanvien.xuat();
            khachhang.xuat();
            Console.WriteLine("Thanh tien : " + thanhtien());
            Console.WriteLine("So hop dong : " + sohopdong);
        }
    }
}
