using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderStockSystem.DatabaseTables
{
   public class Suppliers
    {
        [Key]
        public int Suppliers_Id { get; set; }

        public int Suppliers_kode { get; set; }

        public string Company_Name { get; set; }

        public int Telephone { get; set; }

        public string Authorized_Name { get; set; }

        public int Authorized_Telephone { get; set; }

        public string Mail { get; set; }

        public string Address { get; set; }

        public ICollection<Stock> Stock { get; set; }
    }
}
