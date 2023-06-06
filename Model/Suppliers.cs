using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries.Model
{
    public class Suppliers
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone { get; set; }
    }
}
