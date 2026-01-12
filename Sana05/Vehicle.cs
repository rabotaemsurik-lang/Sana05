using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Vehicle(string brand, string model, int year, decimal price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Рік випуску: {Year}");
            Console.WriteLine($"Ціна: {Price}");
        }
        public virtual decimal CalculateTax()
        {
            return Price * 0.01M;
        }
        public virtual int GetMaxSpeed()
        {
            return 100;
        }



    }
}
