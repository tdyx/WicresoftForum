using System.ComponentModel.DataAnnotations.Schema;

namespace WicresoftForumApi.Data
{
    [Table("Users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserType { get;set; }
        public DateTime CreateTime { get; set; }        
    }
}