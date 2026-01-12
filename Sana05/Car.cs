using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }
        public Car(string brand, string model, int year, decimal price, int numberOfDoors, string fuelType):base(brand, model, year, price)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Машина");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Рік випуску: {Year}");
            Console.WriteLine($"Ціна: {Price}");
            Console.WriteLine($"К-сть дверей: {NumberOfDoors}");
            Console.WriteLine($"Тип палива: {FuelType}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()}" + "км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()}грн");
            Console.WriteLine("----------------------------------------------------");
            
        }
        public override decimal CalculateTax()
        {
            return FuelType == "Електро" ? Price * 0.005M : Price * 0.015M;
        }
        public override int GetMaxSpeed()
        {
            return 180;
        }


    }
}
