using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void  Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("--------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User() {
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

        private static void Create(User user)
        {
            try
            {
                UserRepository repository = new UserRepository();
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso!");
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar usuário.");
                Console.WriteLine(ex.Message);
            }

        }
    }
}