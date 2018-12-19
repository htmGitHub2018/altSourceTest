using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs
{
    public abstract class ProductBase : IProduct
    {
        private List<MaterialUnit> _material = new List<MaterialUnit>();

        public  decimal SellPrice { get; set; }
        public  decimal BuyPrice { get;set;}

        public string Name { get; set; }

    public virtual List<MaterialUnit> GetMaterials()
    {
        //set default size and color for the product, as the requirement the product must has at lease 2 size and various colors
        _material.Add(new MaterialUnit
        {
            Colors = new List<string> { "White", "Red" },
            Size = "1"
        });
        _material.Add(new MaterialUnit
        {
            Colors = new List<string> { "Blue", "Yellow" },
            Size = "2"
        });
        return _material;
    }
}
}
