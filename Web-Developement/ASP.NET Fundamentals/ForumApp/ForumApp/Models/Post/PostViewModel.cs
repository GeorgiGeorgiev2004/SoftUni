using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models.Post
{
    public class PostViewModel
    {
        public int Id { get; init; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
