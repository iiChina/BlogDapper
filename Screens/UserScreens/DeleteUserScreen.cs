using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um usuário");
            Console.WriteLine("--------------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);
            
            Console.Clear();
            MenuUserScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>();
                repository.Delete(id);
                Console.WriteLine("Usuário excluído com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}