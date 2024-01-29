using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Curator : BaseEntity
{
    [Required]
    [Column(TypeName = "nvarchar(max)")]
    public string name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    public string surname { get; set; }

    public List<Group> Groups { get; set; }
}