using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    public class Building
    {
        string address;
        double lon;
        double width;
        double height;

        public Building(string address, double lon, double width, double height)
        {
            this.address = address;
            this.lon = lon;
            this.width = width;
            this.height = height;
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Long
        {
            get { return lon; }
            set { lon = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public void Print()
        {
            Console.WriteLine("Описание здания:");
            Console.WriteLine($"Адрес - {address}");
            Console.WriteLine($"Длинна - {lon}");
            Console.WriteLine($"Ширина - {width}");
            Console.WriteLine($"Высота - {height}");
        }
    }
    public class MultiBuilding : Building
    {
        double floors;
        public MultiBuilding(string address, double lon, double width, double height, double floors)
            : base(address, lon, width, height)
        {
            base.Address = address;
            this.Long = lon;
            this.Width = width;
            this.Height = height;
            this.floors = floors;
        }
        public double Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Этажей - {Height / 2.7}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адресс здания, длинну, ширину и высоту:");
            Building building = new Building(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            building.Print();
            MultiBuilding multiBuilding = new MultiBuilding(building.Address, building.Long, building.Width, building.Height, building.Height);
            Console.WriteLine("----------------");
            Console.WriteLine("Количество этажей с учетом высоты потолка в 2.7 метра:");
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
}