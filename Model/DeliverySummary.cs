using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries.Model
{
    public class DeliverySummary
    {
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public int Weight { get; set; }
        public double Result { get; set; }
    }
}
