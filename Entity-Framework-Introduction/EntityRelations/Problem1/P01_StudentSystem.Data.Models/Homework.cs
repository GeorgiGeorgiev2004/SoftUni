using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models;

public class Homework
{
    public Homework()
    {

    }
    [Key]
    public int HomeworkId { get; set; }
    [Required]
    [Column(TypeName ="varchar")]
    public string Content { get; set; }
    [Required]
    public ContentTypes ContentType { get; set; }
    [Required]
    public DateTime? SubmissionTime { get; set; }
    [Required]
    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }
    public Student Student { get; set; }
    [Required]
    [ForeignKey(nameof(Course))]
    public int CourseId { get; set; }
    public Course Course { get; set; }

    public enum ContentTypes { Application, Pdf, Zip }
}