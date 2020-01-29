using System;

namespace interfaces
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        public bool IsOrderCompleted { get; private set; }

        public int TotalDownloadsLeft { get; set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (IsOrderCompleted == false)
            {
                Console.WriteLine($"Email {Title} to {customer.FirstName} {customer.LastName}");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    IsOrderCompleted = true;
                    TotalDownloadsLeft = 0;
                }

            }
        }
    }
}