using System;
using System.Collections.Generic;
using System.Text;

namespace Kiemtra1
{
    class Person
    {
      public string HoTen { get; set; }
      public string DiaChi { get; set;  }

        public Person() { }
        public Person(string _hoten, string _diachi)
        {
            this.HoTen = _hoten;
            this.DiaChi = _diachi; 
        }
       public virtual void nhap()
        {
            Console.Write("Nhap ho ten : ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi : ");
            DiaChi = Console.ReadLine(); 
        }

    }
}
