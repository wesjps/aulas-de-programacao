using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Entities
{
    enum OrderStatus : int
    {
        Pendingpayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
