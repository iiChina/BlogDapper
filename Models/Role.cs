using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace BlogDapper.Models
{
    [Table("Role")]
    public class Role 
    {
        public Role() => Roles = new List<Role>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }
    }
}