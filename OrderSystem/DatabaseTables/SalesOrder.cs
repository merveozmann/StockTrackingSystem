using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrderStockSystem.DatabaseTables
{
    public class SalesOrder
    {
        [Key]
        public int Order_Id { get; set; }
        public int Order_Kode { get; set; }

        public int Sales_Piece { get; set; }
        public double Unit_Price { get; set; }
        public DateTime Sales_Date { get; set; }
        public double KDV_Rate { get; set; }
        public double Sales_Total { get; set; }
        public double Sales_KDV_Total { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int CustomerKode { get; set; }
        public int ProductKode { get; set; }
        public Boolean Control { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }

       

        public ICollection < Sales> sales { get; set; }
    }
}
