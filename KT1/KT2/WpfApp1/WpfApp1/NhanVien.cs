using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class NhanVien
    {
        public string hoTen { get; set;  }
        public string loaiNhanVien { get; set;  }
        public string ngaySinh { get; set; }
        public int soTienBanDuoc { get; set;  }
        public NhanVien() { }
        public NhanVien(string _hoten, string _loainhanvien, string _ngaysinh, int _sotienbanduoc) {
            this.hoTen = _hoten;
            this.loaiNhanVien = _loainhanvien;
            this.ngaySinh = _ngaysinh;
            this.soTienBanDuoc = _sotienbanduoc; 
        }

    }

}
