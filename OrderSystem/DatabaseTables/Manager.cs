using System.ComponentModel.DataAnnotations;

namespace OrderStockSystem.DatabaseTables
{
   public class Manager
    {
        [Key]
        public int Manager_Id { get; set; }
        public string Name_Surname { get; set; }
        public string User_Adi { get; set; }
        public int Password { get; set; }
    }
}
