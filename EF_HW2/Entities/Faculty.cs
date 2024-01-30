using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Faculty : BaseEntity
{
    [Required] 
    [Column (TypeName = "nvarchar(100)")] // Attribute ile olmur deye OnModelCreatingde Unique Verilib
    public string Name { get; set; }

    public ICollection<Department> Departments { get; set; }   // Navigation Property
}