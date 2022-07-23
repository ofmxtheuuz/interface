using System;
using LocadoraWOUT.Entities;
using LocadoraWOUT.Entities.Services;

namespace LocadoraWOUT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            
            Console.WriteLine("Enter price per hour:");
            double hour = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day:");
            double day = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.processInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
