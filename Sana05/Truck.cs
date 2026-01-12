using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Truck : Vehicle
    {
        public decimal LoadCapacity { get; set; }
        public int NumberOfAxles { get; set; }
        public Truck(string brand, string model, int year, decimal price, decimal loadCapacity, int numberOfAxles) : base(brand, model, year, price)
        {
            LoadCapacity = loadCapacity;
            NumberOfAxles = numberOfAxles;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Вантажівка");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Рік випуску: {Year}");
            Console.WriteLine($"Ціна: {Price}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()}" + "км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()}грн");
            Console.WriteLine($"Вантажопідйомність: {LoadCapacity}");
            Console.WriteLine($"Кількість осей: {NumberOfAxles}");
            Console.WriteLine("----------------------------------------------------");
        }
        public override decimal CalculateTax()
        {
            return Price*0.02M + LoadCapacity*1000;
        }
        public override int GetMaxSpeed()
        {
            return 120;
        }

    }
}
