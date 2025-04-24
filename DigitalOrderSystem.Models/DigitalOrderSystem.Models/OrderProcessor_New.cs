using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOrderSystem.Models
{
    public class OrderProcessor_New
    {
        public void Process(Order order)
        {
            ProductCreator creator = order.ProductType switch
            {
                "Software" => new SoftwareProductCreator(),
                "CloudService" => new CloudServiceProductCreator(),
                _ => throw new Exception("Invalid product type")
            };

            var product = creator.CreateProduct();
            product.Deliver();
        }
    }
}
