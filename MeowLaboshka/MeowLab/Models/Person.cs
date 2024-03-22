using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeowLab.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [property: Required]
        public string Name { get; set; }
        [property: Required]
        public string Surname {  get; set; }
        public int Age { get; set; }
        [property: Required]
        public DateTime Birthday{ get; set; }
    }
}
