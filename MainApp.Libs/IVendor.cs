using MainApp.Libs.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs
{
    public interface IVendor
    {
        string Name { get; set; }
        List<IProduct> GetProductList();
        Order ExecuteOrder(IOrderProcessStep process,Order info);
    }
}
