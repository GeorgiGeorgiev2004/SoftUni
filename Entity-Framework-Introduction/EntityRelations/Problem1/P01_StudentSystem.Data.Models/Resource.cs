using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Resource
{
    [Key]
    public int ResourceId { get; set; }
    [Required]
    [MaxLength(50)]
    [Column(TypeName ="nvarchar")]
    public string Name { get; set; }
    [Column(TypeName = "varchar")]
    [Required]
    public string Url { get; set; }
    [Required]
    public TypeOfResource ResourceType { get; set; }
    public enum TypeOfResource
    {
        Video, Presentation, Document, Other
    }

    [Required]
    [ForeignKey(nameof(Course))]
    public int CourseId { get; set; }
    public Course Course { get; set; }
}