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
                    Name = "All",
                    Description="All Categories.",
                    ImageUrl= "https://images.pexels.com/photos/289586/pexels-photo-289586.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Sports",
                    Description = "This is the sports category.",
                    ImageUrl = "https://images.pexels.com/photos/1171084/pexels-photo-1171084.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Beauty",
                    Description = "This is the beauty category.",
                    ImageUrl = "https://images.pexels.com/photos/2113855/pexels-photo-2113855.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new CategoryModel()
                {
                    Id = 4,
                    Name = "Cars",
                    Description = "This is the cars category.",
                    ImageUrl = "https://images.pexels.com/photos/326259/pexels-photo-326259.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new CategoryModel()
                {
                    Id = 5,
                    Name = "Fashion",
                    Description = "This is the fashion category",
                    ImageUrl = "https://images.pexels.com/photos/135620/pexels-photo-135620.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new CategoryModel()
                {
                    Id = 6,
                    Name = "Gaming",
                    Description = "This is the gaming category",
                    ImageUrl = "https://images.pexels.com/photos/682933/pexels-photo-682933.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new CategoryModel()
                {
                    Id = 7,
                    Name = "Nature",
                    Description = "This is the nature category.",
                    ImageUrl = "https://images.pexels.com/photos/289586/pexels-photo-289586.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
            ];
        }

        public List<CategoryModel> GetCategories()
        {
            return categories;
        }

        public CategoryModel? GetCategoryById(int Id)
        {
            return categories.FirstOrDefault(category => category.Id == Id);
        }
    }
}
