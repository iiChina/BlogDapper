using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listar perfis");
            Console.WriteLine("---------------");
            List();
            Console.ReadLine();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>();
            var roles = repository.Get();

            foreach(var role in roles)
            {
                Console.WriteLine($"{role.Name} - {role.Slug}");
            }
        }
    }
}