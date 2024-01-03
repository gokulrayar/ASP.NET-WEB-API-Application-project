using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Core.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }    
        public int Marks { get; set; }
    }
}
