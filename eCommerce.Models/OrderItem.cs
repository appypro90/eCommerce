using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class OrderItem
    {
       public int OrderItemId {get; set;}
       public int ProductId { get; set; }
       public int Quantity { get; set; }
       public decimal Price { get; set; }
    }
}
