using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models.Post
{
    public class PostFormModel
    {
        [Required]
        [StringLength(Common.ValidationPropertiesModels.TitleMaxLen, MinimumLength = Common.ValidationPropertiesModels.TitleMinLen)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(Common.ValidationPropertiesModels.ContentMaxLen, MinimumLength = Common.ValidationPropertiesModels.ContentMinLen)]
        public string Content { get; set; } = null!;
    }
}
