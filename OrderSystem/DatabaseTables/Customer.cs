using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderStockSystem.DatabaseTables
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public int Customer_Kode { get; set; }

        public string Company_Name { get; set; }

        public int Telephone { get; set; }

        public int Mobile_Phone { get; set; }
        public string Mail { get; set; }
        public string Authorized_Name { get; set; }
        public string Address { get; set; }

        public ICollection<SalesOrder> SalesOrder { get; set; }
        public ICollection<Sales> Sales { get; set; }
    }
}
