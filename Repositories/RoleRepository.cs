using System.Collections.Generic;
using BlogDapper.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class RoleRepository 
    {
        readonly SqlConnection _connection;

        public RoleRepository(SqlConnection connection) => _connection = connection;

        public IEnumerable<Role> Get () => _connection.GetAll<Role>();
        public Role Get(int id) => _connection.Get<Role>(id);
        
        public void Create(Role role) 
        {
            role.Id = 0;
            _connection.Insert<Role>(role);
        } 

        public void Update(Role role) 
        {
            if(role.Id != 0)
                _connection.Update<Role>(role);  
        } 

        public void Delete(Role role) 
        {
            if(role.Id != 0)
                _connection.Delete<Role>(role);  
        } 

        public void Delete(int id) 
        {
            if(id != 0)
                return;

            var role = this.Get(id);
            _connection.Delete<Role>(role);  
        } 
    }   
}