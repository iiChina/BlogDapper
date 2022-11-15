using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um perfil");
            Console.WriteLine("-------------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadLine();
            MenuRoleScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Delete(id);
                Console.WriteLine("Perfil excluído com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível excluir esse perfil!");
                Console.WriteLine(ex.Message);
            }
        } 
    }
}