using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            MultiBuilding multiBuilding = new MultiBuilding();
            Console.WriteLine(building.Print());
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
    public class Building
    {
        public string Address { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building()
        {
            this.Address = "Уваровский переулок д.7";
            this.Lenght = 100;
            this.Width  = 20;
            this.Height = 80;

        }
        public virtual string Print()
        {
            return string.Format("Адрес: {0} Длинна здания: {1} Ширина здания: {2} Высота здания: {3}", Address, Lenght, Width, Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }

        public MultiBuilding() 
            : base()
        {
            this.Floor = 12;
        }
        public override string Print()
        {
            return string.Format("Адрес: {0} Длинна здания: {1} Ширина здания: {2} Высота здания: {3} Этажность: {4}", Address, Lenght, Width, Height, Floor);
        }
    }
}