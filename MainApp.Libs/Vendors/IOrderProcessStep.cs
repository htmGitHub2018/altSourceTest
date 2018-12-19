using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs.Vendors
{
    public interface IOrderProcessStep
    {
        Order ExecuteOrder(Order order);
        IOrderProcessStep NextStep { get; set; }
    }
}
