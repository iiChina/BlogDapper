using System.Collections.Generic;
using System.Linq;
using BlogDapper.Models;
using Dapper;

namespace BlogDapper.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public List<Category> GetWithNumberOfPosts()
        {
            string query = @"
                SELECT [Category].[Id], [Category].[Name], [Post].[Id], [Post].[Title]
                FROM [Category]
                JOIN [Post] ON ([Category].[Id] = [Post].[CategoryId])
            ";

            var categories = new List<Category>();
                
            var items = Database.connection.Query<Category, Post, Category>(query, (category, post) => {
                var cat = categories.FirstOrDefault(x => x.Id == category.Id);
                
                if(cat == null)
                {
                    cat = category;

                    if(post != null)
                        cat.Posts.Add(post);

                    categories.Add(cat);
                }
                else
                    cat.Posts.Add(post);

                return category;
            }, splitOn: "Id"); 

            return categories;
        }
    }
}