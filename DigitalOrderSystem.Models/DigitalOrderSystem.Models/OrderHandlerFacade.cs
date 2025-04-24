using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOrderSystem.Models
{
    public class OrderHandlerFacade
    {
        public void Handle(Order order)
        {
            if (order.OrderMode == "Legacy")
                new OrderProcessor_Old().Process(order);
            else
                new OrderProcessor_New().Process(order);
        }
    }
}
