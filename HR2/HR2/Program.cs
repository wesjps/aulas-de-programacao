using HR2.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HR2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i<= number; i++)
            {
                Console.WriteLine($"Enter Employee #{i} data: ");
                Console.Write("Outsourced? (y/n)? ");
                string conf = Console.ReadLine();
                if (conf == "y" || conf == "Y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per Hour: ");
                    double value = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine());

                    OutsourcedEmployee outsourced = new OutsourcedEmployee(name, hours, value, additional);
                    list.Add(outsourced);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per Hour: ");
                    double value = double.Parse(Console.ReadLine());

                    Employee emp = new Employee(name, hours, value);
                    list.Add(emp);
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine("Name: " + emp.Name + "Payment: " + emp.Payment());
               
            }
        }
    }
}
