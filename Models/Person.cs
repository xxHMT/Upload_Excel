using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Upload.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonID {get; set; }
        public string FullName {get; set; }
        public string Address {get; set; }
    }
}