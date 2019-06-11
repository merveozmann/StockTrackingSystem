using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderStockSystem.DatabaseTables
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public int Product_Kode { get; set; }
        public string Product_Name { get; set; }

        public int Amount { get; set; }
        public string Memory { get; set; }
        public string Usage_Area { get; set; }
        public string Disk_Capacity { get; set; }

        public string Rotation_Speed { get; set; }
        public int Warranty { get; set; }
        public string Size { get; set; }

        public ICollection<SalesOrder> SalesOrder { get; set; }

        public ICollection<Stock> Stock { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
