using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries.Model
{
    public class DeliverySuppliers
    {
        [Key]
        public int DeliverySuppliersID { get; set; }
        public int SupplierID { get; set; }
        public int Count { get; set; }
        public int ProductID { get; set; }
        public int DeliveryID { get; set; }
    }
}
