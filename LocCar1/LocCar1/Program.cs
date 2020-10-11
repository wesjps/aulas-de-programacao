﻿using System;
using System.Globalization;
using System.Xml.Schema;
using LocCar1.Entities;
using LocCar1.Services;

namespace LocCar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data: ");
            Console.Write("Car Model:");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm):");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm):");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter Price per Hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Price per Day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
