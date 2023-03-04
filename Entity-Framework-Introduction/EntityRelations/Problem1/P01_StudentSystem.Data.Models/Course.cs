using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Reflection;

namespace P01_StudentSystem.Data.Models;

public class Course
{
    [Key]
    public int CourseId { get; set; }

    [MaxLength(80)]
    [Column(TypeName = "nvarchar")]
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar")]
    public string? Description { get; set; }
    [Required]
    public DateTime StartDate { get;set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public decimal Price { get; set; }
    public Course()
    {
        this.Homeworks = new HashSet<Homework>();
        this.StudentsCourses = new HashSet<StudentCourse>();
        this.Resources = new HashSet<Resource>();

    }
    [Required]
    public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
    [Required]
    public virtual ICollection<Resource> Resources { get; set; }
    [Required]
    public virtual ICollection<Homework> Homeworks { get; set; }
}