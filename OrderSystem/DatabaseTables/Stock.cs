using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderStockSystem.DatabaseTables
{
    public class Stock
    {
        [Key]
        public int Stock_Id { get; set; }
        public int Stock_Kode { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public DateTime Stock_Date { get; set; }
        public double KDV_Rate { get; set; }

        [ForeignKey("Suppliers")]
        public int SuppliersId { get; set; }
        public int SuppliersKode { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int ProductKode { get; set; }

        public Product Product { get; set; }
        public Suppliers Suppliers { get; set; }
    }
}
