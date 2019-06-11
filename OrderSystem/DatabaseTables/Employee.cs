using System;
using System.ComponentModel.DataAnnotations;


namespace OrderStockSystem.DatabaseTables
{
   public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Name_Surname { get; set; }
        public string Degree { get; set; }
        public string Mail { get; set; }
        public DateTime Star_Date { get; set; }
    }
}
