using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int socanbo; string gt;
            Console.WriteLine("Nhập số cán bộ ");
            socanbo = int.Parse(Console.ReadLine());

            Person ps = new Person();
           
          

            for(int i=1; i<=socanbo; i++)
            {
                ps.InfoPerson(i);
               
                ps.AddListPerSon();
            }
            foreach(var list in ps.listps)
            {
                Console.WriteLine("Thong tin nhan vien: MaNV:{0} HoTen:{1} GioiTinh:{2} QueQuan:{3} NamSinh:{4} TrinhDo:{5} HeSoLuong:{6} PCTrachNhiem:{7} PCAnTrua:{8} Luong:{9} NamTangLuong:{10} XepLoai:{11} ChuyenMon:{12} ",list.MaCanBo,list.Hoten,list.GioiTinh,list.QueQuan,list.NamSinh,list.TrinhDo,list.HeSoLuong,list.PCTrachNhiem,list.AnTrua,list.Luong,list.NamTangLuong,list.XepLoaiLD,list.ChuyenMon);
            }
            Console.WriteLine("Nhap gioi tinh ");
            gt = Console.ReadLine();
            int countgt = ps.countGioitinh(gt);
            Console.WriteLine("So nguoi co gioi tinh {0} ", countgt);
            decimal tongluong = ps.TongLuong();
            Console.WriteLine("Tong luong toan cong ty la {0}", tongluong);
            ps.infoChuyenMon();
            ps.XepLoai();
            string delma;
            Console.WriteLine("Nhap Ma CB ma ban muon xoa: ");
            delma = Console.ReadLine();
            ps.RemoveCB(delma);
            
            foreach(var listmoi in ps.listps)
            {
                Console.WriteLine("Thong tin nhan vien: MaNV:{0} HoTen:{1} GioiTinh:{2} QueQuan:{3} NamSinh:{4} TrinhDo:{5} HeSoLuong:{6} PCTrachNhiem:{7} PCAnTrua:{8} Luong:{9} NamTangLuong:{10} XepLoai:{11} ChuyenMon:{12} ", listmoi.MaCanBo, listmoi.Hoten, listmoi.GioiTinh, listmoi.QueQuan, listmoi.NamSinh, listmoi.TrinhDo, listmoi.HeSoLuong, listmoi.PCTrachNhiem, listmoi.AnTrua, listmoi.Luong, listmoi.NamTangLuong, listmoi.XepLoaiLD, listmoi.ChuyenMon);
            }


            Console.ReadKey();


        }
    }
}
