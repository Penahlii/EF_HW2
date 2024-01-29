using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Group : BaseEntity
{
    [Required]
    [Column (TypeName = "nvarchar(10)")]
    public string Name { get; set; } // Unique Contextde 

    [Required]
    [Range(1, 5, ErrorMessage = "Year must be in the range from 1 to 5")]
    public int Year { get; set; }

    [ForeignKey (nameof(Faculty))]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public List<Curator> Curators { get; set; }
    public List<Lecture> Lectures { get; set; }
    public List<Student> Students { get; set; }
}