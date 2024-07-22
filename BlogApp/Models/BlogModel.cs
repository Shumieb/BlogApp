namespace BlogApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string BlogBody { get; set; }
        public int CategoryId { get; set; }
        public required string Author { get; set; }
        public bool IsFeatured { get; set; } = false;
        public string? ImageUrl { get; set; }
        public DateOnly PublishedDate { get; set; } 
        public int Likes { get; set; } = 0;
    }
}
