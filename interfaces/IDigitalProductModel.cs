using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    interface IDigitalProductModel : IProductModel
    {
        public int TotalDownloadsLeft { get; set; }
    }
}
