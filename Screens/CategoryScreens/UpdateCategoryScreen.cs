using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar uma categoria");
            Console.WriteLine("------------------------");
            Console.WriteLine("Digita o id da categoria: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da categoria: ");
            var name = Console.ReadLine();

            Console.WriteLine("Digite o slug da categoria: ");
            var slug = Console.ReadLine();

            Update(new Category(){
                Id =id, 
                Name = name,
                Slug = slug
            });

            Console.ReadLine();
            MenuCategoryScreen.Load();

        }

        private static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>();
                repository.Update(category);
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            catch(Exception ex)
            {   
                Console.WriteLine("Não foi possível atualizar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}