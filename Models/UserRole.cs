using Dapper.Contrib.Extensions;

namespace BlogDapper.Models
{
    [Table("UserRole")]
    public class UserRole 
    {
        public UserRole()
        {
            
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}