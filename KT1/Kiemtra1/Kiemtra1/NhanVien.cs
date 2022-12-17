using System;

namespace Kiemtra1
{
    class NhanVien : Person
    {
       public string MaNV { get; set;  }
        public string ChucVu { get; set; }
        public float Luong { get; set;  }
        public NhanVien() { }
        public NhanVien(string HoTen, string DiaChi,string _manv, string _chucvu,float _luong) : base (HoTen,DiaChi)
        {
            this.MaNV = _manv;
            this.ChucVu = _chucvu;
            this.Luong = _luong;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap ma nv ");
            MaNV = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu ");
            ChucVu = Console.ReadLine();
            Console.WriteLine("Nhap luong ");
            Luong = float.Parse(Console.ReadLine());
        }
        public int chucVu()
        {
            if(ChucVu=="giam doc")
            {
                return 10; 
            }
            else if(ChucVu=="Truong phong" || ChucVu=="Pho giam doc")
            {
                return 6; 
            }
            else if(ChucVu=="Pho phong")
            {
                return 4; 
            }
            return 2; 
        }
    }
}
