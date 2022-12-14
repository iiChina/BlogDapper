using System;
using System.Collections.Generic;
using System.Linq;
using BlogDapper.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class UserRepository : Repository<User>
    {   
        public List<User> GetWithRoles()
        {
            var query = @"
                SELECT 
                    [User].Name, [User].Email, [Role].Id, [Role].Name
                FROM 
                    [User]
                    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                    LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var users = new List<User>();

            var items = Database.connection.Query<User, Role, User>(query, (user, role) => {
                var usr = users.FirstOrDefault(x => x.Id == user.Id);

                if(usr == null)
                {
                    usr = user;

                    if(role != null)
                        usr.Roles.Add(role);
                        
                    users.Add(usr);
                }
                else
                    usr.Roles.Add(role);

                return user;
            }, splitOn: "Id");

            return users;
        }
    }
}