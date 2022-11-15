using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.PostScreens
{
    public class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar um post");
            Console.WriteLine("----------------");
            Console.Write("Id do post: ");
            var id = int.Parse(Console.ReadLine());
            
            Delete(id);

            Console.ReadLine();
            MenuPostScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>();
                repository.Delete(id);
                Console.WriteLine("Post deletado");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível deletar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}