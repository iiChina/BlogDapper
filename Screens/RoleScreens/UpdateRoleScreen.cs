using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.RoleScreens
{
    public static class UpdateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar um perfil");
            Console.WriteLine("--------------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role() {
                Id = id,
                Name = name, 
                Slug = slug
            });

            Console.ReadLine();
            MenuRoleScreen.Load();
        }

        private static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Update(role);
                Console.WriteLine("Perfil atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o perfil.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}