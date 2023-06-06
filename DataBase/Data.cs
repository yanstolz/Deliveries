using Deliveries.DataBase;
using Deliveries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries.DataBase
{
    public class Data
    {
        public static List<Suppliers> GetSuppliers()
        {
            var list = new List<Suppliers>();
            using (var ctx = new DataContext())
            {
                foreach (var p in ctx.Suppliers)
                {
                    list.Add(p);
                }
            }
            return list;
        }
        public static List<Products> GetProducts()
        {
            var list = new List<Products>();
            using (var ctx = new DataContext())
            {
                foreach (var p in ctx.Products)
                {
                    list.Add(p);
                }
            }
            return list;
        }

        public static List<Delivery> GetDelivery()
        {
            var list = new List<Delivery>();
            using (var ctx = new DataContext())
            {
                foreach (var p in ctx.Delivery)
                {
                    list.Add(p);
                }
            }
            return list;
        }

        public static List<DeliverySuppliers> GetDeliverySuppliers()
        {
            var list = new List<DeliverySuppliers>();
            using (var ctx = new DataContext())
            {
                foreach (var p in ctx.DeliverySuppliers)
                {
                    list.Add(p);
                }
            }
            return list;
        }
        public static void InsertDelivery()
        {
            using (var ctx = new DataContext())
            {
                var delivery = new Delivery()
                {
                    DeliveryDate = DateTime.Now
                };

                ctx.Delivery.Add(delivery);
                ctx.SaveChanges();
            }
        }
        public static void InsertDeliverySuppliers(int supplierID, int count, int productID, int deliveryID)
        {
            using (var ctx = new DataContext())
            {
                var deliverySuppliers = new DeliverySuppliers()
                {
                    SupplierID = supplierID,
                    Count = count,
                    ProductID = productID,
                    DeliveryID = deliveryID
                };

                ctx.DeliverySuppliers.Add(deliverySuppliers);
                ctx.SaveChanges();
            }
        }
        public static List<DeliverySummary> GetDeliverySummary(DateTime startDate, DateTime endDate)
        {
            using (var ctx = new DataContext())
            {
                var query = from deliverySuppliers in ctx.DeliverySuppliers
                            join suppliers in ctx.Suppliers on deliverySuppliers.SupplierID equals suppliers.SupplierID
                            join products in ctx.Products on deliverySuppliers.ProductID equals products.ProductID
                            join delivery in ctx.Delivery on deliverySuppliers.DeliveryID equals delivery.DeliveryID
                            where delivery.DeliveryDate >= startDate && delivery.DeliveryDate <= endDate
                            group new { suppliers.SupplierName, products.ProductName, deliverySuppliers.Count, products.Price } by products.ProductName into g
                            select new DeliverySummary
                            {
                                SupplierName = g.Select(x => x.SupplierName).DefaultIfEmpty(string.Empty).FirstOrDefault(),
                                ProductName = g.Key,
                                Weight = g.Sum(x => x.Count),
                                Result = g.Sum(x => x.Count * x.Price)
                            };

                return query.ToList();
            }
        }


    }
}
