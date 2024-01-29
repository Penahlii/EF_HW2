using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Student : BaseEntity
{
    [Required]
    [Column (TypeName = "nvarchar(max)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    public string Surname { get; set; }

    [Required]
    [Column (TypeName = "int")]
    [Range(0, 5, ErrorMessage = "Rating must be in the range from 0 to 5")]
    public int Rating { get; set; }

    public List<Group> Groups { get; set; }
}