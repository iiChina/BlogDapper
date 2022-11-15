using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load(int type)
        {
            Console.Clear();
            Console.WriteLine("Listar as categorias");
            Console.WriteLine("----------------------");
            if(type == 0)
                List();
            else
                ListCategoriesWithNumberOfPosts();
            Console.ReadLine();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>();
            var categories = repository.Get();

            foreach(var category in categories)
            {
                Console.WriteLine($"{category.Name} - {category.Slug}");
            }
        }

        private static void ListCategoriesWithNumberOfPosts()
        {
            var repository = new CategoryRepository();
            var categories = repository.GetWithNumberOfPosts();

            foreach(var category in categories)
            {
                Console.WriteLine($"{category.Id} - {category.Name}: {category.Posts.Count}");
            }
        }
    }
}