using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar um post");
            Console.WriteLine("------------------");
            Console.Write("Id do post: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Id da categoria: ");
            var categoryId = int.Parse(Console.ReadLine());

            Console.Write("Id do autor: ");
            var authorId = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            var title = Console.ReadLine();

            Console.Write("Resumo: ");
            var summary = Console.ReadLine();

            Console.Write("Publicação: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Post() {
                Id = id,
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

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>();
                repository.Update(post);

                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}