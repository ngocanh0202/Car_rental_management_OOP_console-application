using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class qlxe
    {
        Dictionary<string, xe> danhsach;
        internal Dictionary<string, xe> Danhsach { get => danhsach; set => danhsach = value; }
        public qlxe()
        {
            danhsach = new Dictionary<string, xe>();
        }
        public qlxe(Dictionary<string,xe> danhsach)
        {
            this.danhsach = danhsach;
        }
        
        public void nhap()
        {
            string chon;
            do
            {
                xe x;
                Console.WriteLine("Nhap (H) xe cho hang || Nhap (D) xe du lich || Nhap (0) thoat");
                chon = Console.ReadLine().ToUpper();
                if (chon == "H")
                {
                    x = new xechohang();
                    x.nhap();
                    try
                    {
                        Danhsach.Add(x.Bienxe, x);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Trung key");
                    }
                }
                else if (chon == "D")
                {
                    x = new xedulich();
                    x.nhap();
                    try
                    {
                        Danhsach.Add(x.Bienxe, x);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Trung key");
                    }
                    
                }
                else if (chon == "0")
                    break;
            } while (true);
        }
        public xe tim(string bienso)
        {
            if (Danhsach.ContainsKey(bienso))
                return this.Danhsach[bienso];
            return null;
        }
        public void timxe()
        {
            Console.WriteLine("Nhap bien xe can tim");
            string bienso = Console.ReadLine().ToUpper();
            if (tim(bienso) == null)
                Console.WriteLine("Khong co xe can tim");
            else
            {
                Console.WriteLine("Xe tim duoc la ");
                tim(bienso).xuat();
            }
                
        }
        public void xoaxe()
        {
            Console.WriteLine("Nhap bien xe can xoa : ");
            string bienso = Console.ReadLine().ToUpper();
            if (tim(bienso) != null)
            {
                Danhsach.Remove(tim(bienso).Bienxe);
                Console.WriteLine("Da xoa");
            }
            else
                Console.WriteLine("Khong co xe can tim");
        }
        public void xuat()
        {
            int i = 1;
            if (danhsach.Count <= 0)
                Console.WriteLine("Khong co xe trong danh sach");
            else
            {
                foreach (xe x in Danhsach.Values)
                {
                    Console.WriteLine("------------------Thong tin xe thu " + (i++) + "----------------------");
                    x.xuat();
                }
            }
            
        }
    }
}
