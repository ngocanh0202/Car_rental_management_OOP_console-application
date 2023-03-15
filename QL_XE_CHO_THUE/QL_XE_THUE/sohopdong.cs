using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XE_THUE
{
    class sohopdong
    {
        Dictionary<string, lophongchothue> socai;
        lophongchothue hopdongchothue;
        qlxe qlx; 

        internal Dictionary<string, lophongchothue> Socai { get => socai; set => socai = value; }
        internal lophongchothue Hopdongchothue { get => hopdongchothue; set => hopdongchothue = value; }
        internal qlxe Qlx { get => qlx; set => qlx = value; }

        public sohopdong()
        {
            socai = new Dictionary<string, lophongchothue>();
            hopdongchothue = new lophongchothue();
            Qlx = new qlxe();
        }

        public void nhap()
        {
            
            hopdongchothue = new lophongchothue();
            hopdongchothue.Qlx.Danhsach = qlx.Danhsach;
            hopdongchothue.Nhap();
            try
            {
                qlx.Danhsach = hopdongchothue.Qlx.Danhsach;
                socai.Add(Hopdongchothue.Sohopdong, Hopdongchothue);
            }
            catch (Exception)
            {
                Console.WriteLine("Thuc hien lai !! co the trung so hop dong hoac khong co xe can duoc thue");
            }
            

        }
        public void tim()
        {
            Console.WriteLine("Nhap so hop dong can tim");
            string sohopdong = Console.ReadLine();

            if (socai.ContainsKey(sohopdong))
            {
                socai[sohopdong].Xuat();
            }
            else
                Console.WriteLine("khong co xe de tim");
        }
        public void xoa()
        {
            Console.WriteLine("Nhap so hop dong can xoa ");
            string sohopdong = Console.ReadLine();
            if (socai.ContainsKey(sohopdong))
            {
                socai.Remove(sohopdong);
                Console.WriteLine("Da xoa");
            }
            else
                Console.WriteLine("khong co xe de xoa");
        }
        public void xuat()
        {
            int i = 1;
            if (socai.Count <= 0)
                Console.WriteLine("Khong co xe trong danh sach");
            else
            {
                foreach (var a in socai.Values)
                {
                    Console.WriteLine("----------------------Thong tin xe thue thu " + i++ + "----------------------");
                    a.Xuat();
                }
            }

        }
    }
}
