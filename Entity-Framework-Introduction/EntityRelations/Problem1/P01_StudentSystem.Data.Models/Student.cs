using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [MaxLength(100)]
    [Column(TypeName = "nvarchar")]
    [Required]
    public string Name { get; set; }

    [MaxLength(10)]
    [MinLength(10)]
    [Column(TypeName = "varchar")]
    public string? PhoneNumber { get; set; }

    [Required]
    public DateTime RegisteredOn { get; set; }

    public DateTime? Birthday { get; set; }
    public Student()
    {
        this.Homeworks = new HashSet<Homework>();
        this.StudentsCourses = new HashSet<StudentCourse>();

    }
    [Required]
    public virtual ICollection<Homework> Homeworks { get; set; }

    [Required]
    public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
}
