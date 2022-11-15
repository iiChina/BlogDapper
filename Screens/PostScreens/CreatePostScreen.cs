using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criar novo post");
            Console.WriteLine("----------------");
            Console.Write("Id da categoria: ");
            var categoryId = int.Parse(Console.ReadLine());

            Console.Write("Id do autor: ");
            var authorId = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            var title = Console.ReadLine();

            Console.Write("Resumo: ");
            var summary = Console.ReadLine();

            Console.Write("Conteúdo: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post() {
                CategoryId = categoryId, 
                AuthorId = authorId, 
                Title = title, 
                Summary = summary,
                Body = body, 
                Slug = slug
            });

            Console.ReadLine();
            MenuPostScreen.Load();
        }

        private static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>();
                repository.Create(post);
                Console.WriteLine("Post criado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível criar o post");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}