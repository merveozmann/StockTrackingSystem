using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrderStockSystem.DatabaseTables
{
   public class Sales
    {
        [Key]
        public int Sales_Id { get; set; }
        public int Payment_Kode { get; set; }

        [ForeignKey("SalesOrder")]
        public int OrderId { get; set; }
        public int OrderKode { get; set; }

        public double KDV_Amount { get; set; }
        public double Payment_Amount { get; set; }

        public double Remain_Amount { get; set; }
        public DateTime Date { get; set; }
        public string Explation { get; set; }
        public byte State { get; set; }
        public DateTime Collection_Date { get; set; }
        public double Forwarding_Amount { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int CustomerKode { get; set; }
        public int ProductKode { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public SalesOrder SalesOrder { get; set; }

    }
}
