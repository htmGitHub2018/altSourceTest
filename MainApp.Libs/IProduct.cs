using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs
{
    public interface IProduct
    {
        decimal SellPrice { get; set; }
        decimal BuyPrice { get; set; }
        List<MaterialUnit> GetMaterials();
    }
}
