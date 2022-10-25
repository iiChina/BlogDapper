using System;
using BlogDapper.Models;
using BlogDapper.Repositories;
using Microsoft.Data.SqlClient;

namespace BlogDapper
{
    public class Program
    {
        const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=false";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            ReadUsers(connection);
            ReadRoles(connection);
            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var users = repository.Get();

            foreach(var user in users)
                Console.WriteLine($"{user.Name}");

        }
        
        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new RoleRepository(connection);
            var roles = repository.Get();

            foreach(var role in roles)
                Console.WriteLine($"{role.Name}");

        }

    }
}