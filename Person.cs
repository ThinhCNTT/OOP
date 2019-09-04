using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBoOOP
{
 public   class Person
    {
        #region Atribute
        public string MaCanBo { get; set; }
        public string Hoten { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public int NamSinh { get; set; }
        public string TrinhDo { get; set; }
        public float HeSoLuong { get; set; }
        public float PCTrachNhiem { get; set; }
        public float AnTrua { get; set; }
        public decimal Luong { get; set  ; }
        public int NamTangLuong { get; set; }
        public string XepLoaiLD { get; set; }
        public string ChuyenMon { get; set; }

        #endregion

        #region Method
        public void InfoPerson(int i)
        {
            string macanbo; string hoten; string gioitinh; string quequan; int namsinh; string trinhdo;
            float hesoluong; float pctrachnhiem; float antrua; decimal luong; int namtangluong; string chuyenmon; string xeploaild;
           
            Console.WriteLine("Nhap ma so can bo {0}", i);
            macanbo = Console.ReadLine();
            Console.WriteLine("Nhap ho ten can bo {0}", i);
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh {0}", i);
            gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap que quan {0}", i);
            quequan = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh {0}", i);
            namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap trinh do {0}", i);
            trinhdo = Console.ReadLine();
            Console.WriteLine("Nhap he so luong {0}", i);
            hesoluong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap pc trach nhiem  {0}", i);
            pctrachnhiem = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap pc an trua  {0}", i);
            antrua = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam tang luong {0}", i);
            namtangluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap xep loai ld  {0}", i);
            xeploaild = Console.ReadLine();
            Console.WriteLine("Nhap chuyen mon {0}", i);
            chuyenmon = Console.ReadLine();
           luong = Convert.ToDecimal((hesoluong + pctrachnhiem) * 450000 + antrua);
            this.MaCanBo = macanbo;
            this.Hoten = hoten;
            this.GioiTinh = gioitinh;
            this.QueQuan = quequan;
            this.NamSinh = namsinh;
            this.TrinhDo = trinhdo;
            this.HeSoLuong = hesoluong;
            this.PCTrachNhiem = pctrachnhiem;
            this.AnTrua = antrua;
            this.Luong = luong;
            this.NamTangLuong = namtangluong;
            this.XepLoaiLD = xeploaild;
            this.ChuyenMon = chuyenmon;


        }

        //public void SetPerSon()
        //{
            
            

        //}


        public List<Person> listps = new List<Person>();
        public void AddListPerSon()
        {
            listps.Add(new Person(MaCanBo, Hoten, GioiTinh, QueQuan, NamSinh, TrinhDo, HeSoLuong, PCTrachNhiem, AnTrua, Luong, NamTangLuong, XepLoaiLD, ChuyenMon));
        }

        public int countGioitinh(string gt)
        {
            int countgt = 0;
            for (int i = 0; i < listps.Count(); i++)
            {
                if (listps[i].GioiTinh == gt)
                {
                    countgt++;

                }


            }

            return countgt;
        }

        public decimal TongLuong()
        {
            decimal SumTL=0;
            for(int i = 0; i < listps.Count(); i++)
            {
                SumTL = SumTL + listps[i].Luong;
            }
            

            return SumTL;
        }
        public void infoChuyenMon()
        {
            foreach( var listchuyenmon in listps)
            {
                if (listchuyenmon.ChuyenMon == "CNTT")
                {
                    Console.WriteLine("Can Bo co chuyen mon CNTT:{0} - {1}", listchuyenmon.MaCanBo, listchuyenmon.Hoten);
                }
            }

        }
        public void XepLoai()
        {
            foreach(var listxeploai in listps )
            {
                if (listxeploai.XepLoaiLD == "Gioi")
                {
                    Console.WriteLine("Can Bo Xep Loai Gioi:{0} - {1}", listxeploai.MaCanBo, listxeploai.Hoten);
                }
            }
        }
        public void RemoveCB(string DelMa)
        {
            foreach (var listdel in listps)
            {
                if (listdel.MaCanBo == DelMa)
                {
                    listps.Remove(listdel);
                    return;
                }
                
            }
        }

        #endregion

        #region Contructor
        public Person(string macanbo, string hoten, string gioitinh,string quequan, int namsinh,string trinhdo, float hesoluong, float pctrachnhiem, float antrua,decimal luong,int namtangluong, string xeploaild, string chuyenmon)
        {
            this.MaCanBo = macanbo;
            this.Hoten = hoten;
            this.GioiTinh = gioitinh;
            this.QueQuan = quequan;
            this.NamSinh = namsinh;
            this.TrinhDo = trinhdo;
            this.HeSoLuong = hesoluong;
            this.PCTrachNhiem = pctrachnhiem;
            this.AnTrua = antrua;
            this.Luong = luong;
            this.NamTangLuong = namtangluong;
            this.XepLoaiLD = xeploaild;
            this.ChuyenMon = chuyenmon;


        }
        public Person() { }

        #endregion

    }
}
