using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Motorcycle : Vehicle
    {
        public decimal EngineVolume { get; set; }
        public bool HasWindshield { get; set; }
        public Motorcycle(string brand, string model, int year, decimal price, decimal engineVolume, bool hasWindshield) :base(brand, model, year, price)
        {
            EngineVolume = engineVolume;
            HasWindshield = hasWindshield;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Мотоцикл");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Рік випуску: {Year}");
            Console.WriteLine($"Ціна: {Price}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()}" + "км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()}грн");
            Console.WriteLine($"Об'єм двигуна: {EngineVolume}");
            Console.WriteLine($"Наявність вітрового скла: {(HasWindshield ? "є" : "немає")}");
        }
        public override decimal CalculateTax()
        {
            return Price * 0.008M + EngineVolume * 0.5M;
        }
        public override int GetMaxSpeed()
        {
            return 200;
        }
    }
}
