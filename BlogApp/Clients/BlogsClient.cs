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
                    ImageUrl= "https://placehold.co/600x400"
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
                    ImageUrl = "https://placehold.co/600x400"
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
                    ImageUrl = "https://placehold.co/600x400"
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
                    ImageUrl = "https://placehold.co/600x400"
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
                    ImageUrl = "https://placehold.co/600x400"
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
                    ImageUrl = "https://placehold.co/600x400"
                },
                new BlogModel()
                {
                    Id = 7,
                    Name = "Blog Seven",
                    Description = "This is the description for blog seven.",
                    BlogBody = "This is the blog body for blog seven.",
                    CategoryId = 7,
                    Author = "Author Two",
                    IsFeatured = false,
                    ImageUrl = "https://placehold.co/600x400"
                },
                new BlogModel()
                {
                    Id = 8,
                    Name = "Blog Eight",
                    Description = "This is the description for blog eight.",
                    BlogBody = "This is the blog body for blog eight.",
                    CategoryId = 7,
                    Author = "Author Two",
                    IsFeatured = false,
                    ImageUrl = "https://placehold.co/600x400"
                },
                new BlogModel()
                {
                    Id = 9,
                    Name = "Blog Nine",
                    Description = "This is the description for blog nine.",
                    BlogBody = "This is the blog body for blog nine.",
                    CategoryId = 6,
                    Author = "Author Two",
                    IsFeatured = false,
                    ImageUrl = "https://placehold.co/600x400"
                },
            ];
        }

        public List<BlogModel> GetAllBlogs() 
        { 
            return blogs;
        }

        public List<BlogModel> GetBlogsBySlug(int Id)
        {
            return [.. blogs.FindAll(blog => blog.CategoryId == Id)];
        }

        public List<BlogModel> GetFeaturedBlogs() 
        { 
            return [.. blogs.FindAll(blog=>blog.IsFeatured)];
        }
    }
}
