using System;

namespace interfaces
{
    class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool IsOrderCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (IsOrderCompleted == false)
            {
                Console.WriteLine($"Simulate shipping {Title} to {customer.FirstName} {customer.LastName}");
            }
        }
    }
}