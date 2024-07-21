using BlogApp.Models;

namespace BlogApp.Clients
{
    public class BlogsClient
    {
        private readonly List<BlogModel> blogs;

        public BlogsClient()
        {
            blogs = [
                new BlogModel()
                {
                    Id = 1,
                    Name = "Blog One",
                    Description = "This is the description for blog one.",
                    BlogBody="This is the blog body for the blog body",
                    CategoryId = 1,
                    Author="Author One",
                    IsFeatured=true,
                    IsLatest=false
                },
                new BlogModel()
                {
                    Id = 2,
                    Name = "Blog Two",
                    Description = "This is the description for blog two.",
                    BlogBody = "This is the blog body for blog two",
                    CategoryId = 1,
                    Author = "Author Two",
                    IsFeatured = false,
                    IsLatest = true
                },
                new BlogModel()
                {
                    Id = 3,
                    Name = "Blog Three",
                    Description = "This is the description for blog three.",
                    BlogBody = "This is the blog body for blog three",
                    CategoryId = 1,
                    Author = "Author Three",
                    IsFeatured = true,
                    IsLatest = true
                },
                new BlogModel()
                {
                    Id = 4,
                    Name = "Blog four",
                    Description = "This is the description for blog four.",
                    BlogBody = "This is the blog body for blog four",
                    CategoryId = 4,
                    Author = "Author Two",
                    IsFeatured = true,
                    IsLatest = false
                },
                new BlogModel()
                {
                    Id = 5,
                    Name = "Blog five",
                    Description = "This is the description for blog five.",
                    BlogBody = "This is the blog body for blog five",
                    CategoryId = 3,
                    Author = "Author One",
                    IsFeatured = true,
                    IsLatest = false
                },
                new BlogModel()
                {
                    Id = 6,
                    Name = "Blog Six",
                    Description = "This is the description for blog six.",
                    BlogBody = "This is the blog body for blog six.",
                    CategoryId = 2,
                    Author = "Author Two",
                    IsFeatured = false,
                    IsLatest = true
                },
            ];
        }

        public List<BlogModel> GetBlogs()
        {
            return blogs;
        }

        public List<BlogModel> GetFeaturedBlogs() { 
            return [.. blogs.FindAll(blog=>blog.IsFeatured)];
        }
    }
}
