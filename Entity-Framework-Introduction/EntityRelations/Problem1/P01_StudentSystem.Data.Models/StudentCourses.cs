using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace P01_StudentSystem.Data.Models;

public class StudentCourse
{
    public StudentCourse()
    {

    }
    [ForeignKey(nameof(Student))]
    [Required]
    public int StudentId { get; set; }
    [Required]
    public Student Student { get; set; }

    [ForeignKey(nameof(Course))]
    [Required]
    public int CourseId { get; set; }
    [Required]
    public Course Course { get; set; }
}