using System.ComponentModel.DataAnnotations.Schema;

namespace WicresoftForumApi.Data
{
    [Table("PostTypes")]
    public class PostType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Type { get; set; }
    }
}
