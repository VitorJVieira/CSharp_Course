using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_Challenge.Entities.Enum {
    enum OrderStatus : int {
        Pending_payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
