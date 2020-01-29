using System;
using System.Collections.Generic;

namespace interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cart = AddSampleData();
            var customer = GetCustomer();

            foreach (var prod in cart)
            {
                prod.ShipItem(customer);
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"{digital.Title} left {digital.TotalDownloadsLeft}");
                }
            }

        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Lee"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            var output = new List<IProductModel>();
            output.Add(new PhysicalProductModel {Title = "Book"});
            output.Add(new PhysicalProductModel {Title = "Car"});
            output.Add(new PhysicalProductModel {Title = "Lamp"});
            output.Add(new DigitalProductModel { Title = "Ebook" });
            return output;
        }
    }
}