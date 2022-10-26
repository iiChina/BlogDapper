using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("---------------------");
            Console.Write("Qual o id da tag que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Delete(id);
                Console.WriteLine("Tag excluída com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag");
                Console.WriteLine(ex.Message);
            }

        }
    }
}