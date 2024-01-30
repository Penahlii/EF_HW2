using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace EF_HW2.Entities;

public class Teacher : BaseEntity
{
    [Column(TypeName = "nvarchar(max)")]
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    [Required]
    public string Surname { get; set; }

    [Required]
    [Column(TypeName = "bit")]
    [DefaultValue(0)]
    public bool IsProfessor { get; set; }

    [Required]
    [Column (TypeName = "money")]
    public int Salary { get; set; } 

    public ICollection<Lecture> Lectures { get; set; }
}