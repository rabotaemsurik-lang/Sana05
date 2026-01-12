using Sana05;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>{
                new Car("BMW", "M4 Competition", 2022, 850000, 2, "Бензин"),
                new Truck("MAN", "TGX", 2016, 2500000, 20, 3),
                new Motorcycle("Ducati", "Superleggera v4", 2023, 600000, 1000, true)
            };

        Console.WriteLine("=== Інформація про транспортні засоби ===");

        decimal totalTax = 0;
        Vehicle fastest = vehicles[0];

        for (int i = 0; i < vehicles.Count; i++)
        {
            vehicles[i].DisplayInfo();
            totalTax += vehicles[i].CalculateTax();

            if (vehicles[i].GetMaxSpeed() > fastest.GetMaxSpeed())
            {
                fastest = vehicles[i];
            }
        }
        Console.WriteLine($"Загальна сума податків: {totalTax} грн");
        Console.WriteLine($"Найшвидший транспорт: {fastest.Brand} {fastest.Model} ({fastest.GetMaxSpeed()} км/год)");
    }
}