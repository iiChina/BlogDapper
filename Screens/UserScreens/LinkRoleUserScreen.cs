using System;
using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.UserScreens
{
    public static class LinkRoleUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vicular um perfil");
            Console.WriteLine("--------------------");
            Console.Write("Id do usuário: ");
            var userId = int.Parse(Console.ReadLine());

            Console.Write("Id do perfil: ");
            var roleId = int.Parse(Console.ReadLine());

            CreateLink(new UserRole(){
                UserId = userId,
                RoleId = roleId
            });

            Console.ReadLine();
            MenuUserScreen.Load();
        }

        private static void CreateLink(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>();
                repository.Create(userRole);
                Console.WriteLine("Perfil vinculado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Não foi possível vincular o perfil");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}