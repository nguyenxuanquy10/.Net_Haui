using System;
using System.Collections.Generic;

namespace kt1V2
{
    interface Ivehicle
    {
        void Input();
        void Output();


    }
    class Vehicles
    {
        public string id { get; set; }
        public string marker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public Vehicles() { }

        public Vehicles(string id, string marker, string model, int year, double price)
        {
            this.id = id;
            this.marker = marker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ID : ");
            id = Console.ReadLine();
            Console.Write("Nhap marker : ");
            marker = Console.ReadLine();
            Console.Write("Nhap model :");
            model = Console.ReadLine();
            Console.Write("Nhap year :");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhap price :");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine($"{"id",20} {"marker",20} {"model",20} {"year",20} {"price",20}");
            Console.WriteLine($"{id,20} {marker,20} {model,20} {year,20} {price,20}");
        }

        public override string ToString()
        {
            return "id : " + id + "marker : " + marker + "model : " + model + "year : " + year + "price :" + price;
        }
    }
    class Car : Vehicles
    {
        public string color { get; set; }
        public Car() { }
        public Car(string id, string marker, string model, int year, double price, string color) : base(id, marker, model, year, price)
        {
            this.color = color;

        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap color :");
            color = Console.ReadLine();
        }
        public override void Output()
        {
            Console.WriteLine("THONG TIN CAR");
            base.Output();
            Console.WriteLine("GHI CHU");
            Console.WriteLine("Color : " + color);

        }
    }
    class Truck : Vehicles
    {
        public int taitrong { get; set; }
        public Truck() { }
        public Truck(string id, string marker, string model, int year, double price, int taitrong) : base(id, marker, model, year, price)
        {
            this.taitrong = taitrong;
        }
        public override void Input()
        {
            Console.WriteLine("THONG TIN TRUCK");
            base.Input();
            Console.Write("Nhap tai trong : ");
            taitrong = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("GHI CHU");
            Console.WriteLine("Tai Trong :" + taitrong);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            int choose;

            do
            {

                Console.WriteLine("===================THONG TIN MENU===================");
                Console.WriteLine(" 1. Nhap thong tin ");
                Console.WriteLine(" 2. Xuat thong tin ");
                Console.WriteLine(" 3. Tim thong tin ID ");
                Console.WriteLine(" 4. Tim thong tin Marker ");
                Console.WriteLine(" 5. Sap xep thong tin theo Price ");
                Console.WriteLine(" 6. Sap xep thong tin theo Year:");
                Console.WriteLine(" 7. THEM LUA CHON");
                Console.WriteLine(" 8. THEM THONG TIN  ");
                Console.WriteLine(" 9. XOA THONG TIN THEO ID ");
                Console.WriteLine(" 10. SUA THONG TIN ");
                Console.WriteLine(" 11 .KET THUC CHUONG TRINH");
                Console.WriteLine("Nhap lua chon :");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        nhap(vehicles);
                        break;
                    case 2:
                        xuat(vehicles);
                        break;
                    case 3:
                        timID(vehicles);
                        break;
                    case 4:
                        timmarker(vehicles);
                        break;
                    case 5:
                        Console.WriteLine("Sap Xep theo gia Tang !!!!");
                        SortPriceUp(vehicles);
                        Console.WriteLine("Sap Xep theo gia Giam !!!!");
                        SortPriceDown(vehicles);
                        break;
                    case 6:
                        Console.WriteLine("Sap Xep theo Year Tang !!!!");
                        SortYearUp(vehicles);
                        Console.WriteLine("Sap Xep theo Year Giam !!!!");
                        SortYearDown(vehicles);
                        break;
                    case 7:
                        Console.WriteLine("THEM LUA CHON ");
                        break;
                    case 8:
                        Add(vehicles);
                        break;
                    case 9:
                        Xoa(vehicles);
                        break;
                    case 10:
                        Sua(vehicles);
                        break;
                    case 11:
                        Console.WriteLine("Ket thuc chuong trinh ");

                        break;
                    default:
                        Console.WriteLine("Nhap lai di a!!!!!");
                        break;

                }

            } while (choose != 11);
        }
        public static void nhap(List<Vehicles> vehicles)


        {
            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Xe Car thu {i} ");
                Car c = new Car();
                c.Input();
                vehicles.Add(c);
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Xe Truck thu {i} ");
                Truck t = new Truck();
                t.Input();
                vehicles.Add(t);
            }
        }
        public static void xuat(List<Vehicles> vehicles)
        {
            int i = 1;
            foreach (Vehicles vehicles1 in vehicles)
            {
                Console.WriteLine($"xe thu {i++}");
                vehicles1.Output();
            }
        }
        public static void timID(List<Vehicles> vehicles)
        {
            Console.Write("Nhap ID vehicles : ");
            string ID = Console.ReadLine().Trim();
            var query = (from Vehicles in vehicles
                         where Vehicles.id.Contains(ID.ToLower())
                         select Vehicles
                ).ToList();
            if (query.Count == 0)
            {
                Console.WriteLine("Khong co thong tin");
            }
            else
                foreach (var item in query)
                {
                    item.Output();
                }

        }
        public static void timmarker(List<Vehicles> vehicles)
        {
            Console.Write("Nhap marker vehicles : ");
            string ID = Console.ReadLine().Trim();
            var query = (from Vehicles in vehicles
                         where Vehicles.marker.Contains(ID.ToLower())
                         select Vehicles
                ).ToList();
            if (query.Count == 0)
            {
                Console.WriteLine("Khong co thong tin");
            }
            else
                foreach (var item in query)
                {
                    item.Output();
                }

        }
        public static void SortPriceUp(List<Vehicles> vehicles)
        {
            for (int i = 0; i < vehicles.Count - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Count; j++)
                {
                    if (vehicles[i].price > vehicles[j].price)
                    {
                        Vehicles gt = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = gt;
                    }
                }
            }
            foreach (var item in vehicles)
            {
                item.Output();
            }

        }
        public static void SortPriceDown(List<Vehicles> vehicles)
        {
            for (int i = 0; i < vehicles.Count - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Count; j++)
                {
                    if (vehicles[i].price < vehicles[j].price)
                    {
                        Vehicles gt = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = gt;
                    }
                }
            }
            foreach (var item in vehicles)
            {
                item.Output();
            }

        }
        public static void SortYearUp(List<Vehicles> vehicles)
        {
            for (int i = 0; i < vehicles.Count - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Count; j++)
                {
                    if (vehicles[i].year > vehicles[j].year)
                    {
                        Vehicles gt = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = gt;
                    }
                }
            }
            foreach (var item in vehicles)
            {
                item.Output();
            }

        }
        public static void SortYearDown(List<Vehicles> vehicles)
        {
            for (int i = 0; i < vehicles.Count - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Count; j++)
                {
                    if (vehicles[i].year < vehicles[j].year)
                    {
                        Vehicles gt = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = gt;
                    }
                }
            }
            foreach (var item in vehicles)
            {
                item.Output();
            }

        }
        public static void Add(List<Vehicles> vehicles)
        {
            Console.WriteLine("NHAP THEM PHUONG TIEN ");
            Console.WriteLine("NHAP CHO CAR");
            Car car = new Car();
            car.Input();
            vehicles.Add(car);
            Console.WriteLine("NHAP CHO CAR");
            Truck truck = new Truck();
            truck.Input();
            vehicles.Add(truck);
        }
        public static void Xoa(List<Vehicles> vehicles)
        {
            Console.Write("Nhap ID vehicles muon xoa  : ");
            string x = Console.ReadLine().Trim();
            var query = vehicles.Single(r => r.id == x);
            if (query == null)
            {
                Console.WriteLine("Khong co thong tin ");

            }
            vehicles.Remove(query);
            Console.WriteLine("XOA ROI NHA NHAP 2 DE XEM !!!!");
        }
        public static void Sua(List<Vehicles> vehicles)
        {
            Console.Write("Nhap ID vehicles muon sua : ");
            string ID = Console.ReadLine();

            Car c = new Car();
            Truck t = new Truck();
            if (c.id == ID && t.id == ID)
            {
                foreach (var item in vehicles)
                {
                    item.Output();
                }

            }
        }


    }
    class Program
    {
        public string id { get; set; }
        public string market { get; set; }
        public 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
