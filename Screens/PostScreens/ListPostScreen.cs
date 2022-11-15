using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listar os posts");
            Console.WriteLine("----------------");
            List();
        }

        private static void List()
        {
            var repository = new Repository<Post>();
            var posts = repository.Get();

            foreach(var post in posts)
            {
                Console.WriteLine($"{post.Title} - {post.Slug}");
            }
        }
    }
}