using System.Collections.Generic;

namespace BlogDapper.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}