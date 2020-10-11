using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities
{
    enum OrderStatus
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}
