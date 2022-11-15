using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar um perfil");
            Console.WriteLine("--------------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role() {
                Name = name, 
                Slug = slug
            });

            Console.ReadLine();
            MenuRoleScreen.Load();
        }

        private static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Create(role);
                Console.WriteLine("Perfil cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}