using ForumApp.Data;
using ForumApp.Data.Models;
using ForumApp.Models.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly ForumAppDbContext context;
        public PostController(ForumAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> All()
        {
            var posts = await context.Posts.Select(a => new PostViewModel()
            {
                Id = a.Id,
                Title = a.Title,
                Content = a.Content
            }).ToListAsync();
            return View(posts);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };
            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(All));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var post = await context.Posts.FindAsync(Id);
            PostFormModel model = new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, PostFormModel model)
        {
            var post = await context.Posts.FindAsync(Id);
            post.Title = model.Title;
            post.Content = model.Content;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(All));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            var post = await context.Posts.FirstAsync(a=>a.Id==Id);

            context.Posts.Remove(post);
            await context.SaveChangesAsync();

            return RedirectToAction();
        }
    }
}
