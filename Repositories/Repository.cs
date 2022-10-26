using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogDapper.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        public IEnumerable<TModel> Get() => Database.connection.GetAll<TModel>();

        public TModel Get(int id) =>  Database.connection.Get<TModel>(id);

        public void Create(TModel model) =>  Database.connection.Insert<TModel>(model);

        public void Update(TModel model) =>  Database.connection.Update<TModel>(model);

        public void Delete(TModel model) =>  Database.connection.Delete<TModel>(model);

        public void Delete(int id) 
        {
            var model = Database.connection.Get<TModel>(id);
            Database.connection.Delete<TModel>(model);
        } 
    }
}