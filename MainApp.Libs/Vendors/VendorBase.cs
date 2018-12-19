using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs.Vendors
{
    public abstract class VendorBase : IVendor
    {
        public string Name { get; set; }

        public abstract Order ExecuteOrder(IOrderProcessStep process, Order info);

        public abstract List<IProduct> GetProductList();
    }
}
