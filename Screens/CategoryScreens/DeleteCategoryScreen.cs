using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma categoria");
            Console.WriteLine("----------------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadLine();
            MenuCategoryScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>();
                var category = repository.Get(id);

                repository.Delete(category);
                Console.WriteLine("Categoria deletada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível deletar a categoria");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}