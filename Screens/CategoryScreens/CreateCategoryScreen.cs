using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.WriteLine("Cadastrar uma categoria");
            Console.WriteLine("-----------------------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category() {
                Name = name,
                Slug = slug
            });

            Console.ReadLine();
            MenuCategoryScreen.Load();
        }

        private static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>();
                repository.Create(category);
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar a categoria");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}