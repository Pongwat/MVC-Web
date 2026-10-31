
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApplication.Models
{
    [Table("car")]
    public class Car
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("owner")]
        public int Owner { get; set; }

        [Column("brand")]
        public string Brand { get; set; } = "";

        [Column("model")]
        public string Model { get; set; } = "";

        [Column("model_year")]
        public int ModelYear { get; set; }

        [Column("price")]
        public int Price { get; set; }

        [Column("color")]
        public string Color { get; set; } = "";

        [Column("registration_number")]
        public string RegistrationNumber { get; set; } = "";
    }
}
