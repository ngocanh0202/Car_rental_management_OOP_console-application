using System;

namespace QL_XE_THUE
{
    class Program
    {
        static int chont()
        {
            int chon;
            do
            {
                try
                {
                    chon = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap sai");
                }
            } while (true);
            return chon;
        }
        static void Main(string[] args)
        {
            sohopdong so = new sohopdong();
            int chon;
            do
            {
                
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("1.Nhap thong tin thue xe");
                Console.WriteLine("2.Tim thong tin thue xe");
                Console.WriteLine("3.xoa thong tin thue xe");
                Console.WriteLine("4.Xuat thong tin cua nhung chiec xe duoc thue");
                Console.WriteLine("5.Xuat thong tin xe duoc nhap");
                Console.WriteLine("6.Nhap them cac thong tin xe moi");
                Console.WriteLine("7.Tim xe");
                Console.WriteLine("8.Xoa xe");
                chon = chont();
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        so.nhap();
                        break;
                    case 2:
                        so.tim();
                        break;
                    case 3:
                        so.xoa();
                        break;
                    case 4:
                        so.xuat();
                        break;
                    case 5:
                        so.Qlx.xuat();
                        break;
                    case 6:
                        so.Qlx.nhap();
                        break;
                    case 7:
                        so.Qlx.timxe();
                        break;
                    case 8:
                        so.Qlx.xoaxe();
                        break;
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Nhan Enter de tiep tuc");
                Console.ReadLine();
                Console.Clear();
            } while (chon != 0);
        }
    }
}
