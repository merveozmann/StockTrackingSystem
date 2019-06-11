using System.ComponentModel.DataAnnotations;

namespace OrderStockSystem.DatabaseTables
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public int Password { get; set; }
        public byte Status { get; set; }
        public string Name_Surname { get; set; }
        public int Telephone { get; set; }
        public string Address { get; set; }
    }
}
