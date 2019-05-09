using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
