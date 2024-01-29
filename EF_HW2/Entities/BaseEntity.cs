using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_HW2.Entities;

public class BaseEntity
{
    [Key]
    [Column(TypeName = "bigint")] 
    public int Id { get; set; }

    public BaseEntity() { }
}