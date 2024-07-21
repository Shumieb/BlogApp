using BlogApp.Models;

namespace BlogApp.Clients
{
    public class CategoriesClient
    {
        private readonly List<CategoryModel> categories;

        public CategoriesClient()
        {
            categories = [
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Nature",
                    Description="This is the nature category."                    
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Sports",
                    Description = "This is the sports category."
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Beauty",
                    Description = "This is the beauty category."
                },
                new CategoryModel()
                {
                    Id = 4,
                    Name = "Cars",
                    Description = "This is the cars category."
                },
                new CategoryModel()
                {
                    Id = 5,
                    Name = "Fashion",
                    Description = "This is the fashion category"
                },
            ];
        }

        public List<CategoryModel> GetCategories()
        {
            return categories;
        }
       
    }
}
