using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listar usuários");
            Console.WriteLine("---------------");

            List();
            
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new UserRepository();
            var users = repository.GetWithRoles();

            foreach(var user in users)
            {
                Console.Write($"{user.Name} - {user.Email}: ");
                
                foreach(var role in user.Roles)
                {
                    Console.Write($"{role.Name}, ");
                }

                Console.WriteLine();
            }
        }
    }
}