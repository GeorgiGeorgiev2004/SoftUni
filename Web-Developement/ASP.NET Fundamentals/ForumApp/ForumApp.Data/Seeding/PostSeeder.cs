using ForumApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Data.Seeding
{
    public class PostSeeder
    {
        internal ICollection<Post> SeedPosts()
        {
            var posts = new List<Post>();
            var post = new Post() { };
            post = new Post()
            {
                Id = 1,
                Title = "FirstPost",
                Content= "TestTestTestTestTest",
            };
            posts.Add(post);
            post = new Post()
            {
                Id = 2,
                Title = "SecondPost",
                Content = "TestTestTestTestTestTestTestTestTestTest",
            };
            posts.Add(post);
            post = new Post()
            {
                Id = 3,
                Title = "ThirdPost",
                Content = "TestTestTestTestTestTestTestTestTestTestTestTestTestTestTest",
            };
            posts.Add(post);

            return posts;
        }
    }
}
