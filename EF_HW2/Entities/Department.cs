using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Department : BaseEntity
{
    [Required]
    [Column(TypeName = "int")]
    [Range(1, 5, ErrorMessage = "Building number must be in the range from 1 to 5")]
    public int Building { get; set; }

    [Required]
    [Column (TypeName = "money")]
    [DefaultValue(0)]
    public int Financing { get; set; }

    [Required]  // Attribute ile olmur deye OnModelCreatingde Unique Verilib
    [Column (TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    // Foreign Keys

    [ForeignKey (nameof(Faculty))]
    public int FacultyId { get; set; }
    
    // Navigation Properties
    public Faculty Faculty { get; set; }  
    public ICollection<Group> Groups { get; set; }
}