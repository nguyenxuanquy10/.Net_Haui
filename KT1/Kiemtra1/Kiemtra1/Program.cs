using System;
using System.Collections.Generic; 
using System.Text;

namespace Kiemtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> ds = new List<NhanVien>();
            int x; 
            do {
                Menu();
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Them(ds); 
                            break;
                        }

                    case 2:
                        {
                            HienThi(ds);
                            break;
                        }

                    case 3:
                        {
                            SapXep(ds);
                            break;
                        }
                    default: 
                        {
                            break; 
                        }
                }
            }
            while (x>=1 && x<=3); 
        }
        static void Menu()
        {
            Console.WriteLine("----Menu----");
            Console.WriteLine("1.Them");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Sap xep");
            Console.WriteLine("4. Thoat");
        }
        static void Them(List<NhanVien>ds)
        {
            NhanVien nv = new NhanVien();
            nv.nhap();
            ds.Add(nv);
            Console.WriteLine("Them thanh cong "); 
        }
        static void HienThi(List<NhanVien> ds)
        {
            for(int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }
        }
        static void SapXep(List<NhanVien> ds)
        {
            for(int i = 0; i < ds.Count; i++)
            {
                for(int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i].chucVu() > ds[j].chucVu())
                    {
                        NhanVien nv = ds[i];
                        ds[i] = ds[j];
                        ds[j] = nv; 
                    }
                }
            }
        }
    }
}
