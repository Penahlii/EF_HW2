using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Subject : BaseEntity
{
    [Required]
    [Column (TypeName = "nvarchar(100)")] // Uniqe In Context
    public string Name { get; set; }

    public ICollection<Lecture> Lectue { get; set; }
}