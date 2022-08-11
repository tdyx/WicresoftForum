using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace WicresoftForumApi.Data
{
    [Table("Replies")]
    public class Reply
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? CreatorId { get; set; }
        public User Creator { get; set; }
        public int? PostId { get; set; } // Foreign key
        public Post Post { get; set; } // Reference navigation
        public int FloorId { get; set; }
        [Column(TypeName = "text")]
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteTime { get; set; }
    }
}
