using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    interface IProductModel
    {
         string Title { get; set; }

         bool IsOrderCompleted { get; }

         void ShipItem(CustomerModel customer);

    }
}
