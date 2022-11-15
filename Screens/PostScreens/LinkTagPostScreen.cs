using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.PostScreens
{
    public static class LinkTagPostScreen
    {
        public static void Load()
        {
            Console.Clear();   
            Console.WriteLine("Vincular uma tag");
            Console.WriteLine("------------------");
            Console.Write("Id do post: ");
            var postId = int.Parse(Console.ReadLine());

            Console.Write("Id da tag: ");
            var tagId = int.Parse(Console.ReadLine());

            LinkTag(new PostTag() {
                PostId = postId,
                TagId = tagId    
            });

            Console.ReadLine();
            MenuPostScreen.Load();
        }

        private static void LinkTag(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>();
                repository.Create(postTag);
                Console.WriteLine("Tag vinculada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível vincular a tag!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}