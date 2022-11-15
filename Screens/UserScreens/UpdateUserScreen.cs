using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar usuário");
            Console.WriteLine("------------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new User {
                Id = id,
                Name = name,
                Email = email,
                Slug = slug,
                PasswordHash = "Hash",
                Bio = "Dev",
                Image = "http:\\"
            });

            Console.ReadLine();
            MenuUserScreen.Load();
        }

        private static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>();
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar usuário!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}