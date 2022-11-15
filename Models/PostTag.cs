
using Dapper.Contrib.Extensions;

namespace BlogDapper.Models
{
    [Table("PostTag")]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    } 
}