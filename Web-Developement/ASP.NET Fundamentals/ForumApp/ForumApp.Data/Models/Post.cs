using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Models
{
    public class Post
    {
        [Required]
        [Key]
        public int Id { get; init; }

        [Required]
        [StringLength(Common.ValidationPropertiesModels.TitleMaxLen,MinimumLength = Common.ValidationPropertiesModels.TitleMinLen)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(Common.ValidationPropertiesModels.ContentMaxLen,MinimumLength = Common.ValidationPropertiesModels.ContentMinLen)]
        public string Content { get; set; }=null!;
    }
}