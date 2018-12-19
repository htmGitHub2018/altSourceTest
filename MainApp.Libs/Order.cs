using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs
{
    public class Order
    {
        public List<ProductBase> ProductItems { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
