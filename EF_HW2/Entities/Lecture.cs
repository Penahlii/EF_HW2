using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class Lecture : BaseEntity
{
    [Required]
    [Column(TypeName = "Date")]
    public DateTime Date { get; set; }

    [ForeignKey (nameof(Subject))]
    public int SubjectId { get; set; }
    [ForeignKey (nameof(Teacher))]
    public int TeacherId { get; set; }

    public ICollection<Group> Groups { get; set; }
    public Subject Subject { get; set; }
    public Teacher Teacher { get; set; }
}